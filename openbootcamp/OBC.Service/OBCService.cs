// This file is part of OpenBootCamp.
// Copyright © Sparronator9999 2024-2026.
//
// OpenBootCamp is free software: you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the Free
// Software Foundation, either version 3 of the License, or (at your option)
// any later version.
//
// OpenBootCamp is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
// more details.
//
// You should have received a copy of the GNU General Public License along with
// OpenBootCamp. If not, see <https://www.gnu.org/licenses/>.

using OBC.Common;
using OBC.Common.Configs;
using OBC.IPC;
using OBC.IPC.Messages;
using OBC.Service.Logs;
using OBC.Service.Modules;
using System;
using System.IO;
using System.IO.Pipes;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace OBC.Service;

internal sealed class OBCService : ServiceBase
{
    private readonly NamedPipeServer<IServiceMessage> IPCServer;

    private readonly Logger Log;

    private readonly SMC SMC = new("MacHALDriver");

    private SMCKeyInfo[] SupportedSMCKeys;
    private readonly Timer KeyDumpTimer = new()
    {
        AutoReset = false,
    };

    private KbdEventListener KbdEventListener;
    private FanController FanController;
    private BattManager BattManager;

    private ObcConfig Config;

    public OBCService(Logger logger)
    {
        CanHandlePowerEvent = true;
        CanShutdown = true;
        Log = logger;

        // Only allow config r/w access to clients connecting using an
        // account running as administrator (security feature).
        PipeSecurity sddl = new();
        sddl.SetSecurityDescriptorSddlForm("O:BAG:SYD:(A;;GA;;;SY)(A;;GRGW;;;BA)");
        IPCServer = new NamedPipeServer<IServiceMessage>("ObcConfig", sddl);
        IPCServer.ClientConnected += ClientConnected;
        IPCServer.ClientDisconnected += ClientDisconnected;

        KeyDumpTimer.Elapsed += KeyDumpTimer_Elapsed;
    }

    private void ClientConnected(object sender, PipeConnectionEventArgs<IServiceMessage, IServiceMessage> e)
    {
        e.Connection.ReceiveMessage += ClientMessageReceived;
        Log.Debug($"Client connected to service (ID: {e.Connection.ID})");
    }

    private void ClientDisconnected(object sender, PipeConnectionEventArgs<IServiceMessage, IServiceMessage> e)
    {
        e.Connection.ReceiveMessage -= ClientMessageReceived;
        Log.Debug($"Client disconnected from service (ID: {e.Connection.ID})");
    }

    private void ClientMessageReceived(object sender, PipeMessageEventArgs<IServiceMessage, IServiceMessage> e)
    {
        Log.Debug($"Message received from client (type = {e.Message.Message})");
        switch (e.Message.Message)
        {
            case MessageType.GetConfig:
                Log.Debug($"Sending current config to client #{e.Connection.ID}");
                IPCServer.PushMessage(new ServiceConfigMessage(
                    MessageType.CurrentConfig, Config), e.Connection.ID);
                break;
            case MessageType.ApplyConfig:
                if (e.Message is ServiceConfigMessage msg && msg.Config is not null)
                {
                    Log.Debug($"Applying client #{e.Connection.ID}'s config...");
                    ReloadConf(msg.Config);
                }
                else
                {
                    Log.Error("ApplyConfig message was not of expected type (ServiceConfigMessage) or didn't have the Config field set.");
                }
                    break;
            case MessageType.ReloadConfig:
                Log.Debug("Reloading config from disk...");
                ReloadConf(LoadConf());
                break;
        }
    }

    protected override void OnStart(string[] args)
    {
        Log.Info(Strings.GetString("svcStarting"));

        Config = LoadConf();

        Log.Info("Initialising drivers...");
        if (!SMC.Open())
        {
            Log.Warn(Strings.GetString("errNoMHD"));
        }
        else
        {
            SupportedSMCKeys = SMC.GetSupportedKeys();
            if (SupportedSMCKeys is null || SupportedSMCKeys.Length == 0)
            {
                Log.Error(
                    "Failed to get supported SMC keys:\n" +
                    $"{Utils.GetWin32ErrMsg(SMC.ErrorCode)}");
            }
            else
            {
                if (Config.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnSvcStart))
                {
                    DumpSMCKeys(SupportedSMCKeys);
                }
                if (Config.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnSvcStartDelayed))
                {
                    KeyDumpTimer.Interval = Config.KeyDumpDelayTime * 1000;
                    KeyDumpTimer.Start();
                }
            }
        }

        Log.Info("Starting modules...");
        KbdEventListener = new(Config.KbdEventListener, Log, SMC);
        FanController = new(Config.FanControl, Log, SMC);
        BattManager = new(Config.BatteryManager, Log, SMC);

        KbdEventListener.Start();
        FanController.Start();
        BattManager.Apply();

        IPCServer.Start();

        Log.Info(Strings.GetString("svcStarted"));
    }

    protected override void OnStop()
    {
        StopService();
    }

    protected override void OnShutdown()
    {
        StopService();
    }

    private void StopService()
    {
        Log.Info(Strings.GetString("svcStopping"));
        IPCServer.Stop();

        KbdEventListener?.Stop();
        FanController?.Stop();

        KeyDumpTimer.Stop();
        if (Config.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnSvcStop))
        {
            DumpSMCKeys(SupportedSMCKeys);
        }

        Log.Info("Saving config...");
        Config.Save(Paths.Config);

        Log.Info("Unloading drivers...");
        SMC?.Close();
        Log.Info(Strings.GetString("svcStopped"));
    }

    protected override bool OnPowerEvent(PowerBroadcastStatus powerStatus)
    {
        switch (powerStatus)
        {
            case PowerBroadcastStatus.ResumeCritical:
            case PowerBroadcastStatus.ResumeSuspend:
            case PowerBroadcastStatus.ResumeAutomatic:
                if (Config.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnWake))
                {
                    DumpSMCKeys(SupportedSMCKeys);
                }
                if (Config.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnWakeDelayed))
                {
                    KeyDumpTimer.Interval = Config.KeyDumpDelayTime;
                    KeyDumpTimer.Start();
                }

                // tell all OBC modules that the system is waking up
                KbdEventListener?.Wake();
                FanController?.Wake();
                BattManager?.Apply();
                break;
            case PowerBroadcastStatus.Suspend:
                // tell all OBC modules that the system is about to enter sleep mode
                KbdEventListener?.Sleep();
                FanController?.Sleep();

                if (Config.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnSleep))
                {
                    DumpSMCKeys(SupportedSMCKeys);
                }
                break;
        }
        return true;
    }

    private void ReloadConf(ObcConfig cfg)
    {
        Log.Debug("Restarting service modules...");
        KbdEventListener?.Stop();
        FanController?.Stop();

        // re-create service modules with new config
        Config = cfg;
        KbdEventListener = new(Config.KbdEventListener, Log, SMC);
        FanController = new(Config.FanControl, Log, SMC);
        BattManager = new(Config.BatteryManager, Log, SMC);

        KbdEventListener.Start();
        FanController.Start();
        BattManager.Apply();
        Log.Info("Config reloaded.");

        // send new config to all connected clients
        IPCServer.PushMessage(new ServiceConfigMessage(MessageType.CurrentConfig, Config));
    }

    private ObcConfig LoadConf()
    {
        ObcConfig cfg;
        Log.Info(Strings.GetString("svcConfLoading"));

        try
        {
            cfg = ObcConfig.Load(Paths.Config);
            Log.Info(Strings.GetString("svcConfLoaded"));
        }
        catch (InvalidConfigException)
        {
            Log.Warn(Strings.GetString("wrnBadConf"));
            cfg = new ObcConfig();
        }
        catch (FileNotFoundException)
        {
            Log.Warn(Strings.GetString("wrnNoConf"));
            cfg = new ObcConfig();
        }
        return cfg;
    }

    private void KeyDumpTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        DumpSMCKeys(SupportedSMCKeys);
    }

    private void DumpSMCKeys(SMCKeyInfo[] keys)
    {
        string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
            "Sparronator9999", "OpenBootCamp", "SMCKeyDumps",
            $"smckeys-{DateTime.Now.ToString("s").Replace(':', '-')}.csv");

        Directory.CreateDirectory(Path.GetDirectoryName(path));
        using (StreamWriter sw = new(path))
        {
            Log.Debug($"Dumping SMC keys to {path}...");
            sw.WriteLine("Index,Key,Length,Type,Attributes,Data");

            for (int i = 0; i < keys.Length; i++)
            {
                StringBuilder sb = new($"0x{i:X4},{keys[i].Key},0x{keys[i].Length:X2},{keys[i].TypeString},{keys[i].Attributes.ToString().Replace(",", "")},");
                if ((keys[i].Attributes & SMCKeyAttributes.Read) == SMCKeyAttributes.Read)
                {
                    if (SMC.ReadRawData(keys[i].Key, keys[i].Length, out byte[] data))
                    {
                        for (int j = 0; j < data.Length; j++)
                        {
                            sb.Append($"{data[j]:X2} ");
                        }
                    }
                    else
                    {
                        sb.Append("(null)");
                    }
                }
                sw.WriteLine(sb.ToString());
            }
            Log.Debug($"Finished dumping SMC keys to {path}.");
        }
    }
}

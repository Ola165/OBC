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
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBC.Settings;

public partial class MainForm : Form
{
    private ObcConfig Config;

    private readonly NamedPipeClient<IServiceMessage> IPCClient = new("ObcConfig");

    public MainForm()
    {
        InitializeComponent();
        Icon = Utils.GetEntryAssemblyIcon();

        IPCClient.ServerMessage += ServerMessageReceived;
        IPCClient.Error += IPCError;
    }

    private void tsiExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void tsiAbout_Click(object sender, EventArgs e)
    {
        // TODO: port YAMDCC's About dialog here
        Utils.ShowInfo(Strings.GetString("dlgAbout"), "About");
    }

    private void tsiSource_Click(object sender, EventArgs e)
    {
        Process.Start("https://github.com/Sparronator9999/OpenBootCamp");
    }

    protected async override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        SettingsEnabled(false);

        if (Program.GetServiceStatus("obcsvc", false) == ServiceStatus.Running)
        {
            IPCClient.Start();
            if (await Task.Run(() => IPCClient.WaitForConnection(5000)))
            {
                IPCClient.PushMessage(new ServiceMessage(MessageType.GetConfig));
                return;
            }
        }

        // load the config directly if OBC Service is
        // not running or connecting to it failed
        try
        {
            Config = ObcConfig.Load(Paths.Config);
            LoadConf(Config);
        }
        catch (FileNotFoundException) { }
        catch (DirectoryNotFoundException) { }
    }

    private void ServerMessageReceived(object sender, PipeMessageEventArgs<IServiceMessage, IServiceMessage> e)
    {
        switch (e.Message.Message)
        {
            case MessageType.CurrentConfig:
                if (e.Message is ServiceConfigMessage cfgMessage &&
                    cfgMessage.Config is not null)
                {
                    Config = cfgMessage.Config;
                    LoadConf(Config);
                }
                break;
        }
    }

    private void IPCError(object sender, PipeErrorEventArgs<IServiceMessage, IServiceMessage> e)
    {
        Utils.ShowError($"IPC error occurred!\n{e.Exception}");
    }

    private void LoadConf(ObcConfig cfg)
    {
        chkKbdEventListenerEnable.Checked = cfg.KbdEventListener.Enabled;
        cboFnBehaviour.SelectedIndex = cfg.KbdEventListener.OSXFnBehaviour ? 1 : 0;
        cboBrightness.SelectedIndex = cfg.KbdEventListener.SystemDispBright ? 0 : 1;

        bool timeoutEnabled = cfg.KbdEventListener.KeyLightTimeout > 0;
        chkKeyLightTimeout.Checked = timeoutEnabled;
        numKeyLightTimeout.Enabled = timeoutEnabled;
        numKeyLightTimeout.Value = timeoutEnabled
            ? cfg.KbdEventListener.KeyLightTimeout : 15;

        chkFCEnable.Checked = cfg.FanControl.Enabled;
        numFCPollRate.Value = cfg.FanControl.PollRate / (decimal)1000;
        // TODO: fan control table

        chkBattManEnable.Checked = cfg.BatteryManager.Enabled;
        numChgLim.Value = cfg.BatteryManager.ChargeLimit;

        chkSvcStart.Checked = cfg.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnSvcStart);
        chkSvcStartDelayed.Checked = cfg.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnSvcStartDelayed);
        chkSvcStop.Checked = cfg.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnSvcStop);
        chkSleep.Checked = cfg.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnSleep);
        chkWake.Checked = cfg.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnWake);
        chkWakeDelayed.Checked = cfg.DumpSMCKeys.HasFlag(SMCKeyDumpType.OnWakeDelayed);
        numKeyDumpDelay.Value = cfg.KeyDumpDelayTime;

        SettingsEnabled(true);
    }

    private void SettingsEnabled(bool enable)
    {
        tblKeyboard.Enabled = enable;
        tblFC.Enabled = enable;
        tblBattMan.Enabled = enable;
        tblDbg.Enabled = enable;
    }

    private async void btnInstallMgr_Click(object sender, EventArgs e)
    {
        // disconnect from service to prevent error
        // if service is stopped via install manager
        IPCClient.Stop();

        // show the old install manager dialog
        new InstallMgrForm().ShowDialog();

        // connect to service if it's running
        if (Program.GetServiceStatus("obcsvc", false) == ServiceStatus.Running)
        {
            SettingsEnabled(false);
            IPCClient.Start();
            if (await Task.Run(() => IPCClient.WaitForConnection(5000)))
            {
                IPCClient.PushMessage(new ServiceMessage(MessageType.GetConfig));
                return;
            }
        }
    }

    private void btnConfDir_Click(object sender, EventArgs e)
    {
        try
        {
            Process.Start(Paths.Config);
        }
        catch (Win32Exception)
        {
            Utils.ShowError("Failed to open config directory! (does it exist?)");
        }
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
        IPCClient.PushMessage(new ServiceConfigMessage(MessageType.ApplyConfig, Config));
    }

    private void btnRevert_Click(object sender, EventArgs e)
    {
        IPCClient.PushMessage(new ServiceMessage(MessageType.ReloadConfig));
    }

    private void chkKbdEventListenerEnable_CheckedChanged(object sender, EventArgs e)
    {
        bool enable = ((CheckBox)sender).Checked;
        Config.KbdEventListener.Enabled = enable;
        grpKeyboardSettings.Enabled = enable;
    }

    private void cboFnBehaviour_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool osxFnBehaviour = ((ComboBox)sender).SelectedIndex == 1;
        Config.KbdEventListener.OSXFnBehaviour = osxFnBehaviour;
        lblFnKeyHint.Text = osxFnBehaviour
            ? Strings.GetString("ttFnHintOSX")
            : Strings.GetString("ttFnHintStandard");
    }

    private void cboBrightness_SelectedIndexChanged(object sender, EventArgs e)
    {
        Config.KbdEventListener.SystemDispBright = ((ComboBox)sender).SelectedIndex == 0;
    }

    private void chkKeyLightTimeout_CheckedChanged(object sender, EventArgs e)
    {
        bool enable = ((CheckBox)sender).Checked;
        numKeyLightTimeout.Enabled = enable;
        Config.KbdEventListener.KeyLightTimeout = enable
            ? (int)numKeyLightTimeout.Value : 0;
    }

    private void numKeyLightTimeout_ValueChanged(object sender, EventArgs e)
    {
        Config.KbdEventListener.KeyLightTimeout = (int)numKeyLightTimeout.Value;
    }

    private void chkFCEnable_CheckedChanged(object sender, EventArgs e)
    {
        bool enable = ((CheckBox)sender).Checked;
        Config.FanControl.Enabled = enable;
        grpFCGlobal.Enabled = enable;
        grpFans.Enabled = enable;
    }

    private void numFCPollRate_ValueChanged(object sender, EventArgs e)
    {
        Config.FanControl.PollRate = (int)(((NumericUpDown)sender).Value * 1000);
    }

    private void chkBattManEnable_CheckedChanged(object sender, EventArgs e)
    {
        bool enable = ((CheckBox)sender).Checked;
        Config.BatteryManager.Enabled = enable;
        grpBattMan.Enabled = enable;
    }

    private void numChgLim_ValueChanged(object sender, EventArgs e)
    {
        Config.BatteryManager.ChargeLimit = (byte)((NumericUpDown)sender).Value;
    }

    private void chkSvcStart_CheckedChanged(object sender, EventArgs e)
    {
        if (((CheckBox)sender).Checked)
        {
            Config.DumpSMCKeys |= SMCKeyDumpType.OnSvcStart;
        }
        else
        {
            Config.DumpSMCKeys &= ~SMCKeyDumpType.OnSvcStart;
        }
    }

    private void chkSvcStartDelayed_CheckedChanged(object sender, EventArgs e)
    {
        if (((CheckBox)sender).Checked)
        {
            Config.DumpSMCKeys |= SMCKeyDumpType.OnSvcStartDelayed;
        }
        else
        {
            Config.DumpSMCKeys &= ~SMCKeyDumpType.OnSvcStartDelayed;
        }
    }

    private void chkSvcStop_CheckedChanged(object sender, EventArgs e)
    {
        if (((CheckBox)sender).Checked)
        {
            Config.DumpSMCKeys |= SMCKeyDumpType.OnSvcStop;
        }
        else
        {
            Config.DumpSMCKeys &= ~SMCKeyDumpType.OnSvcStop;
        }
    }

    private void chkSleep_CheckedChanged(object sender, EventArgs e)
    {
        if (((CheckBox)sender).Checked)
        {
            Config.DumpSMCKeys |= SMCKeyDumpType.OnSleep;
        }
        else
        {
            Config.DumpSMCKeys &= ~SMCKeyDumpType.OnSleep;
        }
    }

    private void chkWake_CheckedChanged(object sender, EventArgs e)
    {
        if (((CheckBox)sender).Checked)
        {
            Config.DumpSMCKeys |= SMCKeyDumpType.OnWake;
        }
        else
        {
            Config.DumpSMCKeys &= ~SMCKeyDumpType.OnWake;
        }
    }

    private void chkWakeDelayed_CheckedChanged(object sender, EventArgs e)
    {
        if (((CheckBox)sender).Checked)
        {
            Config.DumpSMCKeys |= SMCKeyDumpType.OnWakeDelayed;
        }
        else
        {
            Config.DumpSMCKeys &= ~SMCKeyDumpType.OnWakeDelayed;
        }
    }

    private void numKeyDumpDelay_ValueChanged(object sender, EventArgs e)
    {
        Config.KeyDumpDelayTime = (int)((NumericUpDown)sender).Value;
    }
}

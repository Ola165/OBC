using MessagePack;

namespace OBC.IPC.Messages;

public enum MessageType
{
    /// <summary>
    /// Fallback value if empty (zero-length) message received by client.
    /// </summary>
    None = 0,
    /// <summary>
    /// Response value sent by service when a previous command ran successfully.
    /// </summary>
    Success,
    /// <summary>
    /// Response value sent by service when a previous command failed.
    /// </summary>
    Failed,
    /// <summary>
    /// Sent in response to a <see cref="GetConfig"/> command,
    /// or to all connected clients when a new config is
    /// applied with <see cref="ApplyConfig"/> or <see cref="ReloadConfig"/>.
    /// </summary>
    CurrentConfig,
    /// <summary>
    /// Request the OBC Service to send the current config to
    /// the requesting client as a Response.Config message.
    /// </summary>
    GetConfig,
    /// <summary>
    /// Request the OBC Service apply and save the provided config.
    /// </summary>
    ApplyConfig,
    /// <summary>
    /// Request the OBC Service reload and apply the config from disk.
    /// </summary>
    ReloadConfig,
}

[Union(0, typeof(ServiceMessage))]
[Union(1, typeof(ServiceStatusMessage))]
[Union(2, typeof(ServiceConfigMessage))]
public interface IServiceMessage
{
    MessageType Message { get; }
}

using MessagePack;
using OBC.Common.Configs;

namespace OBC.IPC.Messages;

[MessagePackObject]
public sealed class ServiceConfigMessage : IServiceMessage
{
    /// <summary>
    /// <see cref="MessageType.GetConfig"/> or <see cref="MessageType.CurrentConfig"/>.
    /// </summary>
    [Key(0)]
    public MessageType Message { get; }

    /// <summary>
    /// The config to send in this message.
    /// </summary>
    [Key(1)]
    public ObcConfig Config { get; set; }

    public ServiceConfigMessage(MessageType message, ObcConfig config)
    {
        Message = message;
        Config = config;
    }
}

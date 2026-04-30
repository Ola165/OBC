using MessagePack;

namespace OBC.IPC.Messages;

[MessagePackObject]
public sealed class ServiceStatusMessage : IServiceMessage
{
    /// <summary>
    /// <see cref="MessageType.Success"/> or <see cref="MessageType.Failed"/>.
    /// </summary>
    [Key(0)]
    public MessageType Message { get; }

    /// <summary>
    /// The command that triggered this message. Used with
    /// <see cref="ServiceMessage.Message"/>, clients can
    /// tell if the command ran successfully or not.
    /// </summary>
    [Key(1)]
    public MessageType Command { get; }

    public ServiceStatusMessage(MessageType message, MessageType command)
    {
        Message = message;
        Command = command;
    }
}

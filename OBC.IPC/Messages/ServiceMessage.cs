using MessagePack;

namespace OBC.IPC.Messages;


[MessagePackObject]
public sealed class ServiceMessage : IServiceMessage
{
    /// <summary>
    /// The message to send through the named pipe.
    /// </summary>
    [Key(0)]
    public MessageType Message { get; }

    public ServiceMessage(MessageType message)
    {
        Message = message;
    }
}

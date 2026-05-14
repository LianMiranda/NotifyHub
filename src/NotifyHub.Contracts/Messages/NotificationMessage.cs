using NotifyHub.Contracts.Enums;

namespace NotifyHub.Contracts.Messages;

public class NotificationMessage
{
    public Guid Id { get; init; }
    public string Recipient { get; init; } = null!;
    public string Subject { get; init; } = null!;
    public string Body { get; init; } = null!;
    public EChannels Channel { get; init; }
    public DateTime CreatedAt { get; init; }
    
    protected NotificationMessage()
    {
        
    }
    
    public NotificationMessage(string recipient, string subject, string body, EChannels channel)
    {
        Id = Guid.NewGuid();
        Recipient = recipient;
        Subject = subject;
        Body = body;
        Channel = channel;
        CreatedAt = DateTime.UtcNow;
    }

}
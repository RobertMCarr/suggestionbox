using System.ComponentModel.DataAnnotations;

namespace SuggestionBox.Core;

public class AuditItems
{
    public Guid ID {get; set;}
    public DateTime Timestamp {get; set;}
    public AuditEventType AuditEventType {get; set;}
    public User EventTriggeringUser {get; set;}

    public AuditItems(DateTime timestamp, AuditEventType eventType, User triggeringUser)
    {
        ID = new Guid();
        Timestamp = timestamp;
        AuditEventType = eventType;
        EventTriggeringUser = triggeringUser;
    }
}

public enum AuditEventType
{
    Created = 0,
    Published = 1,
    Updated = 2,
    StateChanged = 3
}
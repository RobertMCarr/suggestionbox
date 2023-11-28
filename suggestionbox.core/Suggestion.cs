namespace SuggestionBox.Core;

public class Suggestion
{
    public Guid ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User Author { get; set; }
    public List<Comment> Comments {get; set;}
    public List<Tag> SuggestionTypes {get; set;}
    public List<Tag> Statuses {get; set;}
    public List<Tag> Metadata {get; set;}
    public List<CustomField> CustomFields {get; set;}
    public List<Vote> Votes {get; set;}
    public List<AuditItems> Audit {get; set;}

    public Suggestion(Guid id, string title, string description, User author)
    {
        ID = id;
        Title = title;
        Description = description;
        Author = author;

        Comments = new List<Comment>();
        SuggestionTypes = new List<Tag>();
        Statuses = new List<Tag>();
        Metadata = new List<Tag>();
        CustomFields = new List<CustomField>();
        Votes = new List<Vote>();
        Audit = new List<AuditItems>();
    }
}
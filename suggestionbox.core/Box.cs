namespace SuggestionBox.Core;

public class Box
{
    public Guid ID {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public BoxStatuses Status {get; set;}
    public List<Suggestion> Suggestions {get; set;}
    public VisibilityTypes Visibility {get; set;}
    public List<CustomField> CustomFields {get; set;}
    public List<Tag> SuggestionTypes {get; set;}
    public List<Tag> Statuses {get; set;}

    public Box(Guid id, string name, string description)
    {
        ID = id;
        Name = name;
        Description = description;

        Status = BoxStatuses.Closed;
        Suggestions = new List<Suggestion>();
        Visibility = VisibilityTypes.Public;
        CustomFields = new List<CustomField>();
        SuggestionTypes = new List<Tag>();
        Statuses = new List<Tag>();
    }

}

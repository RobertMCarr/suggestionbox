namespace SuggestionBox.Core;

public class Box
{
    public Guid Id {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    public BoxStatuses Status {get; set;}
    public VisibilityTypes Visibility {get; set;}

    public Box(Guid id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = BoxStatuses.Closed;
        Visibility = VisibilityTypes.Public;
    }

}

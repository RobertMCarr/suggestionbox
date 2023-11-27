namespace suggestionbox.core;

public class Box
{
    public Guid ID {get; set;}
    public required string Name {get; set;}
    public required string Description {get; set;}
    public required BoxStatuses Status {get; set;}
    public Suggestion[]? Suggestions {get; set;}
    public VisibilityTypes Visibility {get; set;}
}

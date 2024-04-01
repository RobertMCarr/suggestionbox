namespace SuggestionBox.Core;

public class Suggestion
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid AuthorId { get; set; }
    public int Score { get; set; }
    public Guid BoxId { get; set; }
    public string Tags { get; set; }
    public BoxStatuses Status { get; set; }

    public Suggestion(Guid id, Guid boxId, string title, string description, Guid userId, string tags)
    {
        Id = id;
        Title = title;
        Description = description;
        AuthorId = userId;
        BoxId = boxId;
        Tags = tags;
        Score = 0;
        Status = BoxStatuses.Closed;
    }
}
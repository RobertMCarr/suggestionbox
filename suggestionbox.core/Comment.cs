namespace SuggestionBox.Core;

public class Comment
{ 
    public Guid Id {get; set;}
    public string Content {get;set;}
    public int SuggestionId { get; set;}
    public int UserId { get; set;}

    public Comment(Guid id, int suggestionId, int userId, string content)
    {
        Id = id;
        Content = content;
        SuggestionId = suggestionId;
        UserId = userId;
    }
}

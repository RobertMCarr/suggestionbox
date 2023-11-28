namespace suggestionbox.core;

public class Comment
{ 
    public Guid ID {get; set;}
    public string Body {get;set;}
    public Comment(string body)
    {
        ID = new Guid();
        Body = body;
    }
}

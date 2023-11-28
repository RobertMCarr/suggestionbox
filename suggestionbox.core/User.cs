namespace SuggestionBox.Core;

public class User
{
    public Guid ID {get; set;}
    public string Name {get; set;}

    public User(string name)
    {
        ID = new Guid();
        Name = name;
    }
}

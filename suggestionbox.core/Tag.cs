namespace suggestionbox.core;

public class Tag
{ 
    public Guid ID {get; set;}
    public string Name {get; set;}

    public Tag(string name)
    {
        ID = new Guid();
        Name = name;
    }
}

namespace suggestionbox.core;

public class CustomField
{
    public Guid ID {get; set;}
    public required string Name {get; set;}
    public required bool IsRequired {get; set;}
    public string[]? ValueOptions {get; set;}
}

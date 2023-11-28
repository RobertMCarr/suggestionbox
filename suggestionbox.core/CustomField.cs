using System.Reflection.Metadata.Ecma335;

namespace SuggestionBox.Core;

public class CustomField
{
    public Guid ID {get; set;}
    public string Name {get; set;}
    public bool IsRequired {get; set;}
    public List<string> ValueOptions {get; set;}

    public CustomField(string name, bool isRequired)
    {
        ID = new Guid();
        Name = name;
        IsRequired = isRequired;
        ValueOptions = new List<string>();
    }
}

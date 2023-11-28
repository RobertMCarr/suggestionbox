using SuggestionBox.Core;

namespace SuggestionBox.Core.Utilities;

public class BoxFactory 
{
    public Box Create (string name, string description)
    {
        //1. Validate fields
        if(string.IsNullOrEmpty(name) 
        || string.IsNullOrEmpty(description)) throw new Exception("parameter invalid");

        //2. check authors permissions

        //3. sanitise title and description text
        if(!RichTextTools.SanitiseRichtext(name)
        || !RichTextTools.SanitiseRichtext(description)) throw new Exception("Rich Text failed sanitisation");

        //4. create suggestion
        Box newBox = new Box(new Guid(), name, description);
        newBox.Status = BoxStatuses.Closed;

        //5. return box
        return newBox;
    }
}
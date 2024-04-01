namespace SuggestionBox.Core.Utilities;

public class SuggestionFactory
{
    public Suggestion Create(string title, string description, User author, Box box, string tags)
    {
        //1. Validate fields
        if(string.IsNullOrEmpty(title) 
        || string.IsNullOrEmpty(description) 
        || author == null 
        || box == null) throw new Exception("parameter invalid");

        //2. check authors permissions


        //3. sanitise title and description text
        if(!RichTextTools.SanitiseRichtext(title) 
        || !RichTextTools.SanitiseRichtext(description)) throw new Exception("Rich Text failed sanitisation");

        //4. create suggestion
        Suggestion newSuggestion = new Suggestion(new Guid(), box.Id, title, description, author.Id, tags);

        //5. copy box custom fields to suggestions
        //if(box.CustomFields != null) newSuggestion.CustomFields.AddRange(box.CustomFields.AsEnumerable());
       // if(box.SuggestionTypes != null) newSuggestion.SuggestionTypes.AddRange(box.SuggestionTypes.AsEnumerable());
        //if(box.Statuses != null) newSuggestion.Statuses.AddRange(box.Statuses.AsEnumerable());
        

        //6. add to box
        newSuggestion.BoxId = box.Id;

        //7. return suggestion
        return newSuggestion;
    }
}
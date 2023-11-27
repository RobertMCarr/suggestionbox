using System.Diagnostics.Tracing;

namespace suggestionbox.core;

public class Suggestion
{
    public Guid ID {get; set;}
    public required string Title {get; set;}
    public required string Description {get; set;}
    public required User Author {get; set;}
    public Comment[]? Comments {get; set;}
    public Tag[]? SuggestionType {get; set;}
    public Tag[]? Status {get; set;}
    public Tag[]? Metadata {get; set;}
    public CustomField[]? CustomFields {get; set;}
}
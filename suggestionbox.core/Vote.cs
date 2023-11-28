using suggestionbox.core;

namespace suggestionbox;

public class Vote
{
    public User Voter {get; set;}
    public bool IsPositive {get; set;}

    public Vote(User voter, bool isPositive)
    {
        Voter = voter;
        IsPositive = isPositive;
    }
}
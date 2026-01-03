namespace BehavioralPatterns.ChainOfResponsibility;

public abstract class SupportHandlerBase: ISupportHandler
{
    private ISupportHandler? _nextHandler;

    public ISupportHandler SetNext(ISupportHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual string HandleRequest(string issueType)
    {
        if (_nextHandler != null)
        {
            return _nextHandler.HandleRequest(issueType);
        }
        
        return "Issue cannot be handled.";
    }
}
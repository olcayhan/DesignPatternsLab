namespace BehavioralPatterns.ChainOfResponsibility;

public interface ISupportHandler
{
    ISupportHandler SetNext(ISupportHandler nextHandler);
    string HandleRequest(string issueType);
}
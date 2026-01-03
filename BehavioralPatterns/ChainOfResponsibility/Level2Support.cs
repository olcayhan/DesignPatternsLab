namespace BehavioralPatterns.ChainOfResponsibility;

public class Level2Support : SupportHandlerBase
{
    public override string HandleRequest(string issueType)
    {
        if (issueType == "Billing")
        {
            return "Level 2 (Agent): Refund processed successfully.";
        }
        
        return base.HandleRequest(issueType);
    }
}
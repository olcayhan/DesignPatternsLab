namespace BehavioralPatterns.ChainOfResponsibility;

public class Level3Support : SupportHandlerBase
{
    public override string HandleRequest(string issueType)
    {
        if (issueType == "CriticalError")
        {
            return "Level 3 (Manager): System logs checked, bug report created.";
        }
        
        return base.HandleRequest(issueType);
    }
}
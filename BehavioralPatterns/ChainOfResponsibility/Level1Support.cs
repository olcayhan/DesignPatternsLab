namespace BehavioralPatterns.ChainOfResponsibility;

public class Level1Support : SupportHandlerBase
{
    public override string HandleRequest(string issueType)
    {
        if (issueType == "PasswordReset")
        {
            return "Level 1 (Bot): Password reset link sent via email.";
        }
        
        return base.HandleRequest(issueType);
    }
}
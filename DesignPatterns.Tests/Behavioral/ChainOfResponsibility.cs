using BehavioralPatterns.ChainOfResponsibility;
using Xunit;

namespace DesignPatterns.Tests.Behavioral;

public class ChainOfResponsibilityTests
{
    [Fact]
    public void Request_Should_Pass_Through_Chain_Until_Handled()
    {
        var bot = new Level1Support();
        var agent = new Level2Support();
        var manager = new Level3Support();

        bot.SetNext(agent).SetNext(manager);

        string result1 = bot.HandleRequest("PasswordReset");
        Assert.Contains("Level 1 (Bot)", result1);

        string result2 = bot.HandleRequest("Billing");
        Assert.Contains("Level 2 (Agent)", result2);

        string result3 = bot.HandleRequest("CriticalError");
        Assert.Contains("Level 3 (Manager)", result3);
    }

    [Fact]
    public void Unknown_Request_Should_Reach_End_Of_Chain()
    {
        var bot = new Level1Support();
        var agent = new Level2Support();

        bot.SetNext(agent);
        
        string result = bot.HandleRequest("CoffeeMachineBroken");
        
        Assert.Equal("Issue cannot be handled.", result);
    }
}
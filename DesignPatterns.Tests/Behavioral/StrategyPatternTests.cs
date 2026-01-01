using BehavioralPatterns.Strategy;
using Xunit;

namespace DesignPatterns.Tests.Behavioral;

public class StrategyPatternTests
{
    [Fact]
    public void Standard_Shipping_Should_Calculate_Cost_Correctly()
    {
        var context = new ShippingContext(new StandardShippingStrategy());
        decimal weight = 10m;
        decimal result = context.ExecuteCalculation(weight);
        Assert.Equal(50, result);
    }

    [Fact]
    public void Express_Shipping_Should_Calculate_Higher_Cost()
    {
        var context = new ShippingContext(new ExpressShippingStrategy());
        decimal weight = 10m;
        decimal result = context.ExecuteCalculation(weight);
        Assert.Equal(140, result);
    }
    
    [Fact]
    public void Free_Shipping_Should_Return_Zero()
    {
        var context = new ShippingContext(new FreeShippingStrategy());
        decimal result = context.ExecuteCalculation(500);
        Assert.Equal(0, result);
    }
}
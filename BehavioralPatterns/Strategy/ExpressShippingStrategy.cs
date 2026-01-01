namespace BehavioralPatterns.Strategy;

public class ExpressShippingStrategy : IShippingStrategy
{
    public decimal CalculateCost(decimal weight)
    {
        // Express rate: 12 units per kg + 20 fixed handling fee
        return (weight * 12m) + 20m;
    }
}
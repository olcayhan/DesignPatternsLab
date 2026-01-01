namespace BehavioralPatterns.Strategy;

public class StandardShippingStrategy : IShippingStrategy
{
    public decimal CalculateCost(decimal weight)
    {
        // Standard rate: 5 units per kg
        return weight * 5m;
    }
}
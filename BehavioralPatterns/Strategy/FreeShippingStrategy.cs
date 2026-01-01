namespace BehavioralPatterns.Strategy;

public class FreeShippingStrategy : IShippingStrategy
{
    public decimal CalculateCost(decimal weight)
    {
        // Free shipping for promotions or premium users
        return 0m;
    }
}
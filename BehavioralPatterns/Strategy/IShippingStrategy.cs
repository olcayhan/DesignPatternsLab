namespace BehavioralPatterns.Strategy;

/// <summary>
/// Common interface for all shipping calculation algorithms.
/// </summary>
public interface IShippingStrategy
{
    decimal CalculateCost(decimal weight);
}
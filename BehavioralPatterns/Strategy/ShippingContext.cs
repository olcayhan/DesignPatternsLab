namespace BehavioralPatterns.Strategy;

public class ShippingContext
{
    private IShippingStrategy _strategy;

    // We can inject a default strategy via constructor
    public ShippingContext(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }

    /// <summary>
    /// Allows changing the strategy at runtime.
    /// </summary>
    /// <param name="strategy">The new shipping strategy to be used.</param>
    public void SetStrategy(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal ExecuteCalculation(decimal weight)
    {
        if (_strategy == null)
        {
            throw new InvalidOperationException("Shipping strategy is not set.");
        }

        return _strategy.CalculateCost(weight);
    }
}
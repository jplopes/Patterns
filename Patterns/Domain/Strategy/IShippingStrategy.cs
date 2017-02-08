namespace Domain.Strategy
{
    // Strategy
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }
}
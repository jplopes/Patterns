namespace Domain.Strategy
{
    public class SchenkerShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 3.00d;
        }
    }
}
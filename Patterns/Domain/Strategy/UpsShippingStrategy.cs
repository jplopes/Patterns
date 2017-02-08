namespace Domain.Strategy
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 4.25d;
        }
    }
}
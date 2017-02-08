namespace Domain.Strategy
{
    public class FedexShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 5.00d;
        }
    }
}
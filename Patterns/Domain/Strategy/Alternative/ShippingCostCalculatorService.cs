namespace Domain.Strategy.Alternative
{
    using System;

    public class ShippingCostCalculatorService
    {
        private Func<Order, double> upsStrategy = delegate (Order order) { return 4.00d; };

        public double CalculateShippingCost(Order order, Func<Order, double> shippingCostStrategy)
        {
            return shippingCostStrategy(order);
        }
    }
}
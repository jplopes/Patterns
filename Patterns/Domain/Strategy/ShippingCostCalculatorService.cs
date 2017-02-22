namespace Domain.Strategy
{
    using System;

    public class CostCalculationService
    {
        private readonly IShippingStrategy shippingStrategy;

        public CostCalculationService(IShippingStrategy shippingStrategy)
        {
            this.shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return this.shippingStrategy.Calculate(order);
        }
    }
}
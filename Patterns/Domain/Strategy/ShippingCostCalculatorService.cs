namespace Domain.Strategy
{
    using System;

    public class CostCalculationService
    {
        private readonly IShippingStrategy _shippingStrategy;

        public CostCalculationService(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return _shippingStrategy.Calculate(order);
        }
    }
}
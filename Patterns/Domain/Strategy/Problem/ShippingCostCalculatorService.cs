namespace Domain.Strategy.Problem
{
    using System;

    public class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order)
        {
            switch (order.ShippingMethod)
            {
                case ShippingOptions.FedEx:
                    return this.CalculateForFedEx(order);

                case ShippingOptions.UPS:
                    return this.CalculateForUPS(order);

                case ShippingOptions.Schenker:
                    return this.CalculateForSchenker(order);

                default:
                    throw new Exception("Unknown carrier");
            }
        }

        private double CalculateForSchenker(Order order)
        {
            return 3.00d;
        }

        private double CalculateForUPS(Order order)
        {
            return 4.25d;
        }

        private double CalculateForFedEx(Order order)
        {
            return 5.00d;
        }
    }
}
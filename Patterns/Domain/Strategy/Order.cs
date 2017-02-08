namespace Domain.Strategy
{
    // Strategy
    public class Order
    {
        public ShippingOptions ShippingMethod { get; set; }

        public Address Destination { get; set; }

        public Address Origin { get; set; }
    }
}
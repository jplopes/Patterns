namespace Template
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            OrderShipment service = new UpsOrderShipment();
            service.ShippingAddress = "New York";
            service.Ship(Console.Out);

            OrderShipment serviceTwo = new FedExOrderShipment();
            serviceTwo.ShippingAddress = "Los Angeles";
            serviceTwo.Ship(Console.Out);

            Console.ReadKey();
        }
    }
}

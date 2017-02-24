namespace Mediator
{
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            IAirTrafficControl tower = new Tower();

            Aircraft flight1 = new Airbus("AC159", tower);
            Aircraft flight2 = new Boeing("WS203", tower);
            Aircraft flight3 = new Fokker("AC602", tower);

            flight1.Altitude += 1000;
            Console.ReadKey();
        }
    }
}
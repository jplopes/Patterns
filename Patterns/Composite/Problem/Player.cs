namespace Composite.Problem
{
    using System;

    public class Player
    {
        public string Name { get; set; }

        public double Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} coins.", this.Name, this.Gold);
        }
    }
}
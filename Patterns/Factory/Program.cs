namespace Factory
{
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            string description = args[0];
            IMachine machine = new MachineFactory().CreateInstance(description);
            machine.TurnOn();
            machine.TurnOff();

            Console.ReadKey();
        }
    }
}
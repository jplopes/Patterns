namespace Factory.Problem
{
    using System;

    public class Program
    {
        private static void Main_problem(string[] args)
        {
            string description = args[0];
            IMachine machine = GetMachine(description);
            machine.TurnOn();
            machine.TurnOff();

            Console.ReadKey();
        }

        private static IMachine GetMachine(string description)
        {
            switch (description)
            {
                case "robot":
                    return new Robot();

                case "car":
                    return new Car();

                default:
                    return new UnknownMachine();
            }
        }
    }
}
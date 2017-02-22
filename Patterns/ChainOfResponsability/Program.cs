namespace ChainOfResponsability
{
    using System;

    using Domain.ChainOfResponsibility;

    public class Program
    {
        private static void Main(string[] args)
        {
            ExpenseHandler william = new ExpenseHandler(new Employee("William Worker", decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new Employee("Mary Manager", new decimal(1000)));
            ExpenseHandler victor = new ExpenseHandler(new Employee("Victor Vicepres", new decimal(5000)));
            ExpenseHandler paula = new ExpenseHandler(new Employee("Paula President", new decimal(20000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            decimal expenseReportAmount;
            if (ConsoleInput.TryReadDecimal("Expense report amount:", out expenseReportAmount))
            {
                IExpenseReport expense = new ExpenseReport(expenseReportAmount);
                ApprovalResponse response = william.Approve(expense);
                Console.WriteLine("The request was {0}.", response);
            }

            Console.ReadKey();
        }
    }
}
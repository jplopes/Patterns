namespace ChainOfResponsability.Problem
{
    using System;
    using System.Collections.Generic;

    using Domain.ChainOfResponsibility;

    public class Program
    {
        private static void MainProblem(string[] args)
        {
            List<Employee> managers = new List<Employee>
                                          {
                                              new Employee("William Worker", decimal.Zero),
                                              new Employee("Mary Manager", new decimal(1000)),
                                              new Employee("Victor Vicepres", new decimal(5000)),
                                              new Employee("Paula President", new decimal(20000)),
                                          };

            decimal expenseReportAmount;
            while (ConsoleInput.TryReadDecimal("Expense report amount:", out expenseReportAmount))
            {
                IExpenseReport expense = new ExpenseReport(expenseReportAmount);

                bool expenseProcessed = false;

                foreach (Employee approver in managers)
                {
                    ApprovalResponse response = approver.ApproveExpense(expense);

                    if (response != ApprovalResponse.BeyondApprovalLimit)
                    {
                        Console.WriteLine("The request was {0}.", response);
                        expenseProcessed = true;
                        break;
                    }
                }

                if (!expenseProcessed)
                {
                    Console.WriteLine("No one was able to approve your expense.");
                }
            }
        }
    }
}
namespace Domain.ChainOfResponsibility
{
    public class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(decimal total)
        {
            this.Total = total;
        }

        public decimal Total
        {
            get;
        }
    }
}
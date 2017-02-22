namespace Domain.ChainOfResponsibility
{
    public class Employee : IExpenseApprover
    {
        private readonly decimal approvalLimit;

        public Employee(string name, decimal approvalLimit)
        {
            this.Name = name;
            this.approvalLimit = approvalLimit;
        }

        public string Name { get; private set; }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > this.approvalLimit
                       ? ApprovalResponse.BeyondApprovalLimit
                       : ApprovalResponse.Approved;
        }
    }
}
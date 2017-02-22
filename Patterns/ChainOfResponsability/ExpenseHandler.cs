namespace ChainOfResponsability
{
    using Domain.ChainOfResponsibility;

    public class ExpenseHandler : IExpenseHandler
    {
        private readonly IExpenseApprover approver;

        private IExpenseHandler nextHandler;

        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            this.approver = expenseApprover;
            this.nextHandler = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            ApprovalResponse response = this.approver.ApproveExpense(expenseReport);

            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return this.nextHandler.Approve(expenseReport);
            }

            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            this.nextHandler = next;
        }
    }
}
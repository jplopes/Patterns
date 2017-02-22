namespace ChainOfResponsability
{
    using Domain.ChainOfResponsibility;

    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport);

        void RegisterNext(IExpenseHandler next);
    }
}
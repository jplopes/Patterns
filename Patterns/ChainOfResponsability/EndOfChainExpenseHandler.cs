namespace ChainOfResponsability
{
    using System;

    using Domain.ChainOfResponsibility;

    public class EndOfChainExpenseHandler : IExpenseHandler
    {
        private static readonly EndOfChainExpenseHandler TheInstance = new EndOfChainExpenseHandler();

        private EndOfChainExpenseHandler()
        {
        }

        public static EndOfChainExpenseHandler Instance
        {
            get
            {
                return TheInstance;
            }
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            return ApprovalResponse.Denied;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }
    }
}
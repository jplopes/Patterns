namespace Domain.State
{
    using System;

    public class CanceledState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("Cannot ship, already canceled.");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("Already canceled.");
        }

        public OrderStatus Status
        {
            get
            {
                return OrderStatus.Canceled;
            }
        }
    }
}
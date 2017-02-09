namespace Domain.State
{
    public class NewState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return true;
        }

        public void Ship(Order order)
        {
            // actual shipping logic ignored, only changing the status
            order.Change(new ShippedState());
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public void Cancel(Order order)
        {
            // actual cancellation logic ignored, only changing the status;
            order.Change(new CanceledState());
        }

        public OrderStatus Status
        {
            get
            {
                return OrderStatus.New;
            }
        }
    }
}
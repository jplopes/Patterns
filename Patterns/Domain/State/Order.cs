namespace Domain.State
{
    using System;

    public class Order
    {
        private IOrderState orderState;

        public Order(IOrderState orderState)
        {
            this.orderState = orderState;
        }

        public int Id { get; set; }

        public string Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatus Status
        {
            get
            {
                return this.orderState.Status;
            }
        }

        public bool CanCancel()
        {
            return this.orderState.CanCancel(this);
        }

        public void Cancel()
        {
            if (this.CanCancel())
            {
                this.orderState.Cancel(this);
            }
        }

        public bool CanShip()
        {
            return this.orderState.CanShip(this);
        }

        public void Ship()
        {
            if (this.CanShip())
            {
                this.orderState.Ship(this);
            }
        }

        public void Change(IOrderState orderState)
        {
            this.orderState = orderState;
        }
    }
}
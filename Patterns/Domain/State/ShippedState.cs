﻿namespace Domain.State
{
    using System;

    public class ShippedState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("Already shipped.");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("Already shipped, cannot cancel.");
        }

        public OrderStatus Status
        {
            get
            {
                return OrderStatus.Shipped;
            }
        }
    }
}
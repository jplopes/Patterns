namespace Template
{
    using System;

    public class UpsOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            // Call UPS Web Service
            this.Label = string.Format("UPS:[{0}]", this.ShippingAddress);
        }
    }
}
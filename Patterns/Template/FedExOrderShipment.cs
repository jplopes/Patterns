namespace Template
{
    using System;

    public class FedExOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            // Call FedEx Web Service
            this.Label = string.Format("FedEx:[{0}]", this.ShippingAddress);
        }
    }
}
namespace Mediator
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl atc;

        private int currentAltitude;

        protected Aircraft(string callSign, IAirTrafficControl atc)
        {
            this.atc = atc;
            this.CallSign = callSign;
            this.atc.RegisterAircraftUnderGuidance(this);
        }

        public abstract int Ceiling { get; }

        public string CallSign { get; private set; }

        public int Altitude
        {
            get
            {
                return this.currentAltitude;
            }

            set
            {
                this.currentAltitude = value;
                this.atc.ReceiveAircraftLocation(this);
            }
        }

        public void Climb(int heightToClimb)
        {
            this.Altitude += heightToClimb;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            var incoming = (Aircraft)obj;
            return this.CallSign.Equals(incoming.CallSign);
        }

        public override int GetHashCode()
        {
            return this.CallSign.GetHashCode();
        }

        public void WarnOfAirspaceIntrusionBy(Aircraft reportingAircraft)
        {
            // do something in response to the warning
        }
    }
}
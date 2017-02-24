namespace Mediator
{
    public class Boeing : Aircraft
    {
        public Boeing(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 33000; }
        }
    }
}
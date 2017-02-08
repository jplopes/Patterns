namespace Decorator
{
    public class Activity : Vacation
    {
        public override string Description
        {
            get
            {
                return "Activity";
            }
        }

        public override int Price
        {
            get
            {
                return 4;
            }
        }
    }
}
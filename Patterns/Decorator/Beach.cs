namespace Decorator
{
    public class Beach : Vacation
    {
        public override string Description
        {
            get
            {
                return "Beach";
            }
        }

        public override int Price
        {
            get
            {
                return 2;
            }
        }
    }
}
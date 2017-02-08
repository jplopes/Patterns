namespace Decorator
{
    public class Recreation : Vacation
    {
        public override string Description
        {
            get
            {
                return "Recreation";
            }
        }

        public override int Price
        {
            get
            {
                return 3;
            }
        }
    }
}
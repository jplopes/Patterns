namespace Decorator
{
    public class PrivatePool : VacationDecorator
    {
        public PrivatePool(Vacation vacation)
            : base(vacation)
        {
        }

        public override string Description
        {
            get
            {
                return string.Concat(this.Vacation.Description, ", Private pool.");
            }
        }

        public override int Price
        {
            get
            {
                return this.Vacation.Price + 2;
            }
        }
    }
}
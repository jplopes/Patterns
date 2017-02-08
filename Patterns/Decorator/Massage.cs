namespace Decorator
{
    public class Massage : VacationDecorator
    {
        public Massage(Vacation vacation)
            : base(vacation)
        {
        }

        public override string Description
        {
            get
            {
                return string.Concat(this.Vacation.Description, ", Massage.");
            }
        }

        public override int Price
        {
            get
            {
                return this.Vacation.Price + 1;
            }
        }
    }
}
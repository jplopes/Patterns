namespace Decorator
{
    public class AllInclusive : VacationDecorator
    {
        public AllInclusive(Vacation vacation)
            : base(vacation)
        {
        }

        public override string Description
        {
            get
            {
                return string.Concat(this.Vacation.Description, ", All inclusive.");
            }
        }

        public override int Price
        {
            get
            {
                return this.Vacation.Price + 3;
            }
        }
    }
}
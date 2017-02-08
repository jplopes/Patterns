namespace Decorator
{
    public class VacationDecorator : Vacation
    {
        private readonly Vacation vacation;

        public VacationDecorator(Vacation vacation)
        {
            this.vacation = vacation;
        }

        public Vacation Vacation
        {
            get
            {
                return this.vacation;
            }
        }

        public override string Description
        {
            get
            {
                return this.vacation.Description;
            }
        }

        public override int Price
        {
            get
            {
                return this.vacation.Price;
            }
        }
    }
}
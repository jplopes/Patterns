namespace Interpreter
{
    using System.Collections.Generic;

    public class CondimentList : IExpression
    {
        private readonly List<ICondiment> condiments;

        public CondimentList(List<ICondiment> condiments)
        {
            this.condiments = condiments;
        }

        public void Interpret(Context context)
        {
            foreach (ICondiment condiment in this.condiments)
            {
                condiment.Interpret(context);
            }
        }
    }
}
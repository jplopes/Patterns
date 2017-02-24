namespace Interpreter
{
    using System;

    public class Sandwich : IExpression
    {
        private readonly IBread topBread;

        private readonly CondimentList topCondiments;

        private readonly IngredientList ingredients;

        private readonly CondimentList bottomCondiments;

        private readonly IBread bottomBread;

        public Sandwich(
            IBread topBread,
            CondimentList topCondiments,
            IngredientList ingredients,
            CondimentList bottomCondiments,
            IBread bottomBread)
        {
            this.topBread = topBread;
            this.topCondiments = topCondiments;
            this.ingredients = ingredients;
            this.bottomCondiments = bottomCondiments;
            this.bottomBread = bottomBread;
        }

        public void Interpret(Context context)
        {
            context.Output += "|";
            this.topBread.Interpret(context);
            context.Output += "|";
            context.Output += "<--";
            this.topCondiments.Interpret(context);
            context.Output += "-";
            this.ingredients.Interpret(context);
            context.Output += "-";
            this.bottomCondiments.Interpret(context);
            context.Output += "-->";
            context.Output += "|";
            this.bottomBread.Interpret(context);
            context.Output += "|";
            Console.WriteLine(context.Output);
        }
    }
}
namespace Interpreter
{
    using System.Collections.Generic;

    public class IngredientList : IExpression
    {
        private readonly List<IIngredient> ingredients;

        public IngredientList(List<IIngredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void Interpret(Context context)
        {
            foreach (IIngredient ingredient in this.ingredients)
            {
                ingredient.Interpret(context);
            }
        }
    }
}
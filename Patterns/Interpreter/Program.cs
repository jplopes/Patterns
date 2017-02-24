namespace Interpreter
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main(string[] args)
        {
            Sandwich sandhich = new Sandwich(
                new WheatBread(),
                new CondimentList(
                    new List<ICondiment> { new MayoCondiment(), new MustardCondiment() }),
                new IngredientList(
                    new List<IIngredient> { new LettuceIngredient(), new ChickenIngredient() }),
                new CondimentList(new List<ICondiment> { new KetchupCondiment() }),
                new WheatBread());

            sandhich.Interpret(new Context());


            Console.ReadKey();
        }
    }
}
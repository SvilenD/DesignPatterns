namespace Template
{
    using System;

    public class Sourdough : Bread
    {
        private const int bakingMinutes = 20;

        public override void Bake()
        {
            Console.WriteLine(bakingMsg, this.GetType().Name, bakingMinutes);
        }

        public override void MixIngredients()
        {
            Console.WriteLine(mixingIngredientsMsg, this.GetType().Name);
        }
    }
}
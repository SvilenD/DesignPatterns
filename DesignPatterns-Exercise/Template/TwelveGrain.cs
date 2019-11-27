namespace Template
{
    using System;

    public class TwelveGrain : Bread
    {
        private const int bakingMinutes = 25;

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
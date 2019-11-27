namespace Template
{
    using System;

    public class WholeWheat : Bread
    {
        private const int bakingMinutes = 15;

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
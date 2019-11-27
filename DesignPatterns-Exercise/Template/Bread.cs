namespace Template
{
    using System;

    public abstract class Bread
    {
        private const string slicingOutputMsg = "Slicing the {0} bread!";

        protected const string mixingIngredientsMsg = "Gathering ingredients for {0} bread.";

        protected const string bakingMsg = "Baking the {0} bread. ({1} minutes)";

        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine(slicingOutputMsg, this.GetType().Name);
        }

        //The Template Method
        public void Make()
        {
            this.MixIngredients();
            this.Bake();
            this.Slice();
        }
    }
}
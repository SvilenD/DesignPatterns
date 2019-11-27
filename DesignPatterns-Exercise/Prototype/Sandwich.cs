using System;

namespace Prototype
{
    public class Sandwich : SandwichPrototype
    {
        private const string cloningMsg = "Cloning sandwich with ingredients: {0}";

        private readonly string bread;
        private readonly string meat;
        private readonly string cheese;
        private readonly string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientList();
            Console.WriteLine(cloningMsg, ingredientList);

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            return $"{this.bread}, {this.meat}, {this.cheese}, {this.veggies}";
        }
    }
}

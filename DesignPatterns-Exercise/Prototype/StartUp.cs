namespace Prototype
{
    public class StartUp
    {
        public static void Main()
        {
            var sandwichMenu = new SandwichMenu();

            sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            sandwichMenu["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly");
            sandwichMenu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

            sandwichMenu["ThreeMeat"] = new Sandwich("White", "Turkey, Ham, Salami", "cheese", "Lettuce, Onion, Tomato");

            var sandwichBlt = sandwichMenu["BLT"].Clone() as Sandwich;
            var sandwich3Meat = sandwichMenu["ThreeMeat"].Clone() as Sandwich;
            var sandwichTurkey = sandwichMenu["Turkey"].Clone() as Sandwich;
        }
    }
}
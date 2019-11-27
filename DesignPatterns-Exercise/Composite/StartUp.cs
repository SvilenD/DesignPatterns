namespace Composite
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var phone = new SingleGift("phone", 500);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var rootBox = new CompositeGift("RootBox", 0);
            var truckToy = new SingleGift("truck", 55.5m);
            var carToy = new SingleGift("car", 35.5m);
            rootBox.Add(truckToy);
            rootBox.Add(carToy);

            var childBox = new CompositeGift("childBox", 0);
            var soldierToy = new SingleGift("soldier", 12.20m);
            childBox.Add(soldierToy);
            rootBox.Add(childBox);
            Console.WriteLine($"Total price of the composite gift is: {rootBox.CalculateTotalPrice()}");
        }
    }
}
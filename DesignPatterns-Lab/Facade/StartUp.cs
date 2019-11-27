namespace Facade
{
    using Facade.Builders;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var car = new CarBuilderFacade()
                .Info
                    .WithType("Bmw")
                    .WithColor("Blue")
                    .WithNumberOfDoors(5)
                .Built
                    .InCity("Leipzig")
                    .AtAddress("unknown address")
                .Build();

            Console.WriteLine(car);
        }
    }
}
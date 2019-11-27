namespace SingletonDemo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var db = SingletonDataContainer.Instance;

            Console.WriteLine(db.GetPopulation("Sofia"));
        }
    }
}
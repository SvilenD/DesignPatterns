namespace SingletonDemo
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class SingletonDataContainer : ISingletonContainer
    {
        private static readonly SingletonDataContainer instance = new SingletonDataContainer();

        private readonly string initializationMsg = "Initialing singleton object";

        private readonly Dictionary<string, int> capitals = new Dictionary<string, int>();

        private SingletonDataContainer()
        {
            Console.WriteLine(initializationMsg);

            AddData();
        }

        public int GetPopulation(string name)
        {
            return capitals[name];
        }

        public static SingletonDataContainer Instance => instance;


        private void AddData()
        {
            var elements = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < elements.Length; i++)
            {
                var line = elements[i].Split();
                var name = line[0];
                var population = int.Parse(line[1]);

                capitals.Add(name, population);
            }
        }
    }
}
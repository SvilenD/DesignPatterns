using System;

namespace Facade
{
    public class Car
    {
        private readonly string carInfo = "Car Type: {0}, Color: {1}, Number of doors: {2}, Manufactured in {3}, at address: {4}";

        public string Type { get; set; }

        public string Color { get; set; }

        public int NumberOfDoors { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return String.Format(carInfo, this.Type, this.Color, this.NumberOfDoors, this.City, this.Address);
        }
    }
}
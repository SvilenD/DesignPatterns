namespace CommandPattern
{
    using System;

    public class Product
    {
        private readonly string increasePriceOutput = "The price for the {0} has been increased by {1}.";
        private readonly string decreasePriceOutput = "The price for the {0} has been decreased by {1}.";
        private readonly string productPriceOutput = "Current price for the {0} product is {1}.";

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public void IncreasePrice(decimal amount)
        {
            this.Price += amount;
            Console.WriteLine(String.Format(increasePriceOutput, this.Name, amount));
        }

        public bool DecreasePrice(decimal amount)
        {
            if (amount < this.Price)
            {
                this.Price -= amount;
                Console.WriteLine(String.Format(decreasePriceOutput, this.Name, amount));
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return String.Format(productPriceOutput, this.Name, this.Price);
        }
    }
}
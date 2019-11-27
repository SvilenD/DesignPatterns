namespace Composite
{
    using System;

    public class SingleGift : GiftBase
    {
        private const string giftPriceMsg = "{0} with the price {1}";
        public SingleGift(string name, decimal price) 
            : base(name, price)
        {
        }

        public override decimal CalculateTotalPrice()
        {
            Console.WriteLine(giftPriceMsg, this.name, this.price);
            return price;
        }
    }
}
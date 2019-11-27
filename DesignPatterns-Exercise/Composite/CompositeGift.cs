namespace Composite
{
    using System;
    using System.Collections.Generic;

    public class CompositeGift : GiftBase, IGiftOperations
    {
        private const string priceOutputMsg = "{0} contains the following products with prices:";

        private readonly List<GiftBase> gifts;

        public CompositeGift(string name, decimal price)
            : base(name, price)
        {
            this.gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            this.gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            this.gifts.Remove(gift);
        }

        public override decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            Console.WriteLine(priceOutputMsg, this.name);

            foreach (var gift in gifts)
            {
                totalPrice += gift.CalculateTotalPrice();
            }

            return totalPrice;
        }
    }
}
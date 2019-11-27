namespace CommandPattern.Core
{
    public class ProductCommand : ICommand
    {
        private readonly Product product;
        private readonly PriceAction priceAction;
        private readonly decimal amount;

        public bool IsCommandExecuted { get; private set; }

        public ProductCommand(Product product, PriceAction priceAction, decimal amount)
        {
            this.product = product;
            this.priceAction = priceAction;
            this.amount = amount;
        }

        public void ExecuteAction()
        {
            if (this.priceAction == PriceAction.Increase)
            {
                this.product.IncreasePrice(this.amount);
                this.IsCommandExecuted = true;
            }
            else
            {
                this.IsCommandExecuted = this.product.DecreasePrice(this.amount);
            }
        }

        public void UndoAction()
        {
            if (this.IsCommandExecuted == false)
            {
                return;
            }

            if (this.priceAction == PriceAction.Increase)
            {
                this.product.DecreasePrice(this.amount);
            }
            else
            {
                this.product.IncreasePrice(this.amount);
            }
        }
    }
}
namespace Facade.Builders
{
    public class CarBuilderFacade
    {
        protected Car Car { get; set; }

        public CarBuilderFacade()
        {
            this.Car = new Car();
        }

        public Car Build() => Car;

        public CarInfoBuilder Info => new CarInfoBuilder(this.Car);
        public CarAddressBuilder Built => new CarAddressBuilder(this.Car);
    }
}
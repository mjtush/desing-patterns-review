using BeverageShop.DecoratorPattern.Condiments;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern
{
    internal class Mocha : CondimentDecorator
    {
        private readonly double _cost = 0.20;

        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => this.Beverage.Description + ", Mocha";

        public override double Cost()
        {
            return this.Beverage.Cost() + _cost;
        }
    }
}

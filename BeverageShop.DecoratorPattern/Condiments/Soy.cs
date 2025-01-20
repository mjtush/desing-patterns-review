using BeverageShop.DecoratorPattern.Condiments;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern
{
    internal class Soy : CondimentDecorator
    {
        private readonly double _cost = 0.15;

        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => this.Beverage.Description + ", Soy";

        public override double Cost()
        {
            return this.Beverage.Cost() + _cost;
        }
    }
}

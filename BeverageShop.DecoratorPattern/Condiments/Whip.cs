using BeverageShop.DecoratorPattern.Condiments;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern
{
    internal class Whip : CondimentDecorator
    {
        private readonly double _cost = 0.10;

        public Whip(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => this.Beverage.Description + ", Whip";

        public override double Cost()
        {
            return this.Beverage.Cost() + _cost;
        }
    }
}

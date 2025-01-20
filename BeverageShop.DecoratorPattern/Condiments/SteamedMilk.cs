using BeverageShop.DecoratorPattern.Condiments;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern
{
    internal class SteamedMilk : CondimentDecorator
    {
        private readonly double _cost = 0.20;

        public SteamedMilk(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => this.Beverage.Description + ", Steamed Milk";

        public override double Cost()
        {
            return this.Beverage.Cost() + _cost;
        }
    }
}

using BeverageShop.DecoratorPattern.Condiments;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern
{
    internal class Whip : CondimentDecorator
    {
        private double _costForSmallSizeCup = 0.05;
        private double _costForMiddleSizeCup = 0.10;
        private double _costForBigSizeCup = 0.15;

        public Whip(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => this.Beverage.Description + ", Whip";

        public override double Cost()
        {
            var cost = Beverage.Cost();
            cost += Beverage.Size switch
            {
                Size.Small => _costForSmallSizeCup,
                Size.Medium => _costForMiddleSizeCup,
                Size.Big => _costForBigSizeCup,
                _ => 0
            };

            return cost;
        }
    }
}

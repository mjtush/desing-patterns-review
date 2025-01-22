using BeverageShop.DecoratorPattern.Condiments;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern
{
    internal class SteamedMilk : CondimentDecorator
    {
        private double _costForSmallSizeCup = 0.15;
        private double _costForMiddleSizeCup = 0.20;
        private double _costForBigSizeCup = 0.25;

        public SteamedMilk(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => this.Beverage.Description + ", Steamed Milk";

        public override double Cost()
        {
            var cost = Beverage.Cost();
            switch (Beverage.Size)
            {
                case Size.Small:
                    cost += _costForSmallSizeCup;
                    break;
                case Size.Medium:
                    cost += _costForMiddleSizeCup;
                    break;
                case Size.Big:
                    cost += _costForBigSizeCup;
                    break;
            }

            return cost;
        }
    }
}

using BeverageShop.DecoratorPattern.Condiments;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern.Condiments
{
    internal class Soy : CondimentDecorator
    {
        private readonly double _costForSmallSizeCup = 0.1;
        private readonly double _costForMiddleSizeCup = 0.15;
        private readonly double _costForBigSizeCup = 0.2;

        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => Beverage.Description + ", Soy";

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

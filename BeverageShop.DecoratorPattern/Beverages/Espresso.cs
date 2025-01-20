
namespace BeverageShop.DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        private readonly double _cost;

        public Espresso()
        {
            DescriptionField = "Espresso";
            _cost = 1.99;
        }

        public override string Description => DescriptionField;

        public override double Cost()
        {
            return _cost;
        }
    }
}

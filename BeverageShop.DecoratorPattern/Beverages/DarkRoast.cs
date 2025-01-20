
namespace BeverageShop.DecoratorPattern.Beverages
{
    internal class DarkRoast : Beverage
    {
        private readonly double _cost;

        public DarkRoast()
        {
            DescriptionField = "Dark Roast";
            _cost = 0.99;
        }

        public override string Description => DescriptionField;

        public override double Cost()
        {
            return _cost;
        }
    }
}

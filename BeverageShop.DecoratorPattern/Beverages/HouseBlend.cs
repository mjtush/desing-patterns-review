
namespace BeverageShop.DecoratorPattern.Beverages
{
    internal class HouseBlend : Beverage
    {
        private readonly double _cost;

        public HouseBlend()
        {
            DescriptionField = "House Blend";
            _cost = 0.89;
        }

        public override string Description => DescriptionField;

        public override double Cost()
        {
            return _cost;
        }
    }
}

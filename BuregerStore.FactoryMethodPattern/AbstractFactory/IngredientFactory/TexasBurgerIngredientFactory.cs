using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory.IngredientFactory
{
    internal class TexasBurgerIngredientFactory : IBurgerIngredientFactory
    {
        public Roll CreateRoll()
        {
            return new WhiteRoll();
        }

        public Meat CreateBeef()
        {
            return new TexasBeef();
        }

        public Meat CreatePork()
        {
            return new TexasPork();
        }

        public Meat CreateChicken()
        {
            return new TexasChicken();
        }

        public Meat CreateVeggieMeat()
        {
            return new TexasVeggieMeat();
        }

        public Veggie[] CreateVeggies() => new Veggie[] { new Lettuce(), new Peakle(), new Onion() };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory.IngredientFactory
{
    internal class PolishBurgerIngredientFactory : IBurgerIngredientFactory
    {
        public Roll CreateRoll()
        {
            return new WholeWheatRoll();
        }

        public Meat CreateBeef()
        {
            return new PolishBeef();
        }

        public Meat CreatePork()
        {
            return new PolishPork();
        }

        public Meat CreateChicken()
        {
            return new PolishChicken();
        }

        public Meat CreateVeggieMeat()
        {
            return new PolishVeggieMeat();
        }

        public Veggie[] CreateVeggies()
        {
            return [new Lettuce(), new SourCucumber(), new Onion()];
        }
    }
}

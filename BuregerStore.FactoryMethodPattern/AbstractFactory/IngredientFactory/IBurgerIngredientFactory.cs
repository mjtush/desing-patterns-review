using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory.IngredientFactory
{
    public interface IBurgerIngredientFactory
    {
        public Roll CreateRoll();
        public Meat CreateBeef();
        public Meat CreatePork();
        public Meat CreateChicken();
        public Meat CreateVeggieMeat();
        public Veggie[] CreateVeggies();
    }
}

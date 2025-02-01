using System.Reflection;
using System.Transactions;
using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients;
using static System.Console;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory
{
    public abstract class Burger
    {
        protected string Name;
        protected Roll? Roll;
        protected Meat? Meat;
        protected Veggie[]? Trimmings;
       

        public virtual void Grill()
        {
            WriteLine($"Grilling {Meat}");
        }

        public abstract void Prepare();

        public virtual void Box()
        {
            WriteLine($"Placing burger in a box.");
        }

        public string GetName => Name;

    }
}

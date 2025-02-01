using System.Reflection;
using System.Transactions;
using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.IngredientFactory;
using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients;
using static System.Console;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory
{
    public abstract class Burger
    {
        protected string Name = string.Empty;
        protected Roll? Roll;
        protected Meat? Meat;
        protected Veggie[]? Trimmings;

        public virtual void Grill()
        {
            WriteLine(Meat?.Name != null ? $"Grilling {Meat.Name}" : "Meat is not specified yet.");
        }

        public abstract void Prepare();

        public virtual void Box()
        {
            WriteLine($"Placing burger in a box.");
        }

        public string GetName => Name;

        protected virtual void DisplayIngredients(Roll roll, Meat meat, Veggie[] trimmings)
        {
            Console.WriteLine($"{roll.Name}");
            Console.WriteLine($"{meat.Name}");
            foreach (var trimming in trimmings)
            {
                Console.WriteLine($"{trimming.Name}");
            }
        }
    }
}

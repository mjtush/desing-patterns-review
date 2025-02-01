using static System.Console;

namespace BurgerStoreApp.FactoryMethodPattern
{
    public abstract class Burger
    {
        protected string Name;
        protected string Roll;
        protected string Meat;
        protected List<string> Trimmings = ["Cheese", "Cucumber", "Tomato"];

        public virtual void Grill()
        {
            WriteLine($"Grilling {Meat}");
        }

        public virtual void Prepare()
        {
            WriteLine($" Preparing {Name}.");
            WriteLine($" Cutting {Roll} and tossing {Meat} on it.");
            WriteLine(" Adding Trimmings:");
            foreach (var trimming in Trimmings)
            {
                WriteLine($"  {trimming}");
            }
        }

        public virtual void Box()
        {
            WriteLine($"Placing burger in a box.");
        }

        public string GetName => Name;

    }
}

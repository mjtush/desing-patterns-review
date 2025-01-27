using static System.Console;

namespace BurgerStore.FactoryMethodPattern
{
    public abstract class Burger
    {
        protected string Name;
        protected string Roll;
        protected string Meat;
        protected List<string> Trimmings = [];


        public virtual void Fry()
        {
            WriteLine($"Frying {Meat}");
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

    }
}

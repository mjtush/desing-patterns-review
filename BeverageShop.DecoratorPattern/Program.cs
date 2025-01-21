using static System.Console;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern
{
    internal class Program
    {
        public static void Main()
        {
            Beverage beverage = new Espresso();

            WriteLine($"{beverage.Description} ${beverage.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            WriteLine($"{beverage2.Description} ${beverage2.Cost()}");

            Beverage beverage3 = new DarkRoast();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);

            WriteLine($"{beverage3.Description} ${beverage3.Cost()}");

            Beverage beverage4 = new DarkRoast();
            beverage4 = new Soy(beverage4);
            beverage.Size = Size.Medium;

            WriteLine($"{beverage4.Description} ${beverage4.Cost()}");
        }
    }
}

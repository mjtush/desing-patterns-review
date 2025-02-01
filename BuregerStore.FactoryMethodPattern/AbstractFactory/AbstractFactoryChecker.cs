using static System.Console;


namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory
{
    internal static class AbstractFactoryChecker
    {
        public static void Run()
        {
            BurgerStore plBurgerStore = new PolishBurgerStore();
            BurgerStore txBurgerStore = new TexasBurgerStore();
            Burger burger = plBurgerStore.OrderBurger("pork");
            WriteLine($"{burger.GetName} has been ordered\n");
            burger = txBurgerStore.OrderBurger("beef");
            WriteLine($"{burger.GetName} has been ordered\n");
        }
    }
}

using BurgerStores.FactoryMethodPattern;

BurgerStore plBurgerStore = new PolishBurgerStore();
BurgerStore txBurgerStore = new TexasBurgerStore();

Burger burger = plBurgerStore.OrderBurger("pork");
Console.WriteLine($"{burger.GetName} has been ordered\n");

burger = txBurgerStore.OrderBurger("beef");
Console.WriteLine($"{burger.GetName} has been ordered\n");

Console.ReadKey();



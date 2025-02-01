using BurgerStore = BurgerStoreApp.FactoryMethodPattern.BurgerStore;
using PolishBurgerStore = BurgerStoreApp.FactoryMethodPattern.PolishBurgerStore;
using TexasBurgerStore = BurgerStoreApp.FactoryMethodPattern.TexasBurgerStore;
using Burger = BurgerStoreApp.FactoryMethodPattern.Burger;
using BurgerStoreApp.FactoryMethodPattern.AbstractFactory;

BurgerStore plBurgerStore = new PolishBurgerStore();
BurgerStore txBurgerStore = new TexasBurgerStore();

Burger burger = plBurgerStore.OrderBurger("pork");
Console.WriteLine($"{burger.GetName} has been ordered\n");

burger = txBurgerStore.OrderBurger("beef");
Console.WriteLine($"{burger.GetName} has been ordered\n");

Console.WriteLine($"\nChecking implementation of Abstract Factory Pattern for ingredients into Burger Sore\n");
AbstractFactoryChecker.Run();

Console.ReadKey();



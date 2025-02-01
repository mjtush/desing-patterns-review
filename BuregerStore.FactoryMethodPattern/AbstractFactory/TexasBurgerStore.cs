using BurgerStoreApp.FactoryMethodPattern;
using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.IngredientFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory
{
    internal class TexasBurgerStore : BurgerStore
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory = new TexasBurgerIngredientFactory();
        protected override Burger CreateBurger(string type) => type switch
        {
            "beef" => new TexasBeefBurger(_burgerIngredientFactory),
            "chicken" => new TexasChickenBurger(_burgerIngredientFactory),
            "pork" => new TexasPorkBurger(_burgerIngredientFactory),
            "Veggie" => new TexasVeggieBurger(_burgerIngredientFactory),
            _ => new TexasBeefBurger(_burgerIngredientFactory)
        };
    }

    internal class TexasBeefBurger : Burger
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory;
        public TexasBeefBurger(IBurgerIngredientFactory burgerIngredientFactory)
        {
            _burgerIngredientFactory = burgerIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Roll = _burgerIngredientFactory.CreateRoll();
            Meat = _burgerIngredientFactory.CreateBeef();
            Trimmings = _burgerIngredientFactory.CreateVeggies();
        }
    }

    internal class TexasChickenBurger : Burger
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory;
        public TexasChickenBurger(IBurgerIngredientFactory burgerIngredientFactory)
        {
            _burgerIngredientFactory = burgerIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Roll = _burgerIngredientFactory.CreateRoll();
            Meat = _burgerIngredientFactory.CreateChicken();
            Trimmings = _burgerIngredientFactory.CreateVeggies();
        }
    }

    internal class TexasPorkBurger : Burger
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory;
        public TexasPorkBurger(IBurgerIngredientFactory burgerIngredientFactory)
        {
            _burgerIngredientFactory = burgerIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Roll = _burgerIngredientFactory.CreateRoll();
            Meat = _burgerIngredientFactory.CreatePork();
            Trimmings = _burgerIngredientFactory.CreateVeggies();
        }
    }

    internal class TexasVeggieBurger : Burger
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory;
        public TexasVeggieBurger(IBurgerIngredientFactory burgerIngredientFactory)
        {
            _burgerIngredientFactory = burgerIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Roll = _burgerIngredientFactory.CreateRoll();
            Meat = _burgerIngredientFactory.CreateVeggieMeat();
            Trimmings = _burgerIngredientFactory.CreateVeggies();
        }
    }
}

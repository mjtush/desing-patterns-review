using BurgerStoreApp.FactoryMethodPattern;
using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.IngredientFactory;
using static System.Console;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory
{
    internal class PolishBurgerStore : BurgerStore
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory = new PolishBurgerIngredientFactory();
        protected override Burger CreateBurger(string type) => type switch
        {
            "beef" => new PolishBeefBurger(_burgerIngredientFactory),
            "chicken" => new PolishChickenBurger(_burgerIngredientFactory),
            "pork" => new PolishPorkBurger(_burgerIngredientFactory),
            "veggie" => new PolishVeggieBurger(_burgerIngredientFactory),
            _ => new PolishBeefBurger(_burgerIngredientFactory)
        };
    }

    internal class PolishBeefBurger : Burger
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory;
        public PolishBeefBurger(IBurgerIngredientFactory burgerIngredientFactory)
        {
            _burgerIngredientFactory = burgerIngredientFactory;
            Name = "Polish Beef Burger";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Roll = _burgerIngredientFactory.CreateRoll();
            Meat = _burgerIngredientFactory.CreateBeef();
            Trimmings = _burgerIngredientFactory.CreateVeggies();
            DisplayIngredients(Roll, Meat, Trimmings);
        }
    }

    internal class PolishChickenBurger : Burger
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory;
        public PolishChickenBurger(IBurgerIngredientFactory burgerIngredientFactory)
        {
            _burgerIngredientFactory = burgerIngredientFactory;
            Name = "Polish Chicken Burger";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Roll = _burgerIngredientFactory.CreateRoll();
            Meat = _burgerIngredientFactory.CreateChicken();
            Trimmings = _burgerIngredientFactory.CreateVeggies();
            DisplayIngredients(Roll, Meat, Trimmings);
        }
    }

    internal class PolishPorkBurger : Burger
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory;
        public PolishPorkBurger(IBurgerIngredientFactory burgerIngredientFactory)
        {
            _burgerIngredientFactory = burgerIngredientFactory;
            Name = "Polish Pork Burger";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Roll = _burgerIngredientFactory.CreateRoll();
            Meat = _burgerIngredientFactory.CreatePork();
            Trimmings = _burgerIngredientFactory.CreateVeggies();
            DisplayIngredients(Roll, Meat, Trimmings);
           
        }
    }

    internal class PolishVeggieBurger : Burger
    {
        private readonly IBurgerIngredientFactory _burgerIngredientFactory;
        public PolishVeggieBurger(IBurgerIngredientFactory burgerIngredientFactory)
        {
            _burgerIngredientFactory = burgerIngredientFactory;
            Name = "Polish Veggie Burger";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}.");
            Roll = _burgerIngredientFactory.CreateRoll();
            Meat = _burgerIngredientFactory.CreateVeggieMeat();
            Trimmings = _burgerIngredientFactory.CreateVeggies();
            DisplayIngredients(Roll, Meat, Trimmings);
        }
    }
}

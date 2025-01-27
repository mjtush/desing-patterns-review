using BurgerStore.FactoryMethodPattern;

namespace BurgerStore.FactoryMethodPattern
{
    internal class PolishBurgerStore : BurgerStore
    {
        protected override Burger CreateBurger(string type) => type switch
        {
            "beef" => new PolishBeefBurger(),
            "chicken" => new PolishChickenBurger(),
            "pork" => new PolishPorkBurger(),
            "weggie" => new PolishWeggieBurger(),
            _ => new PolishBeefBurger()
        };
    }

    internal class PolishBeefBurger : Burger
    {
        public PolishBeefBurger()
        {
            Name = "Polish Beef Burger";
            Roll = "White Roll";
            Meat = "Grilled Beef";
        }
    }

    internal class PolishChickenBurger : Burger
    {
        public PolishChickenBurger()
        {
            Name = "Polish Chicken Burger";
            Roll = "White Roll";
            Meat = "Grilled Chicken";
        }
    }

    internal class PolishPorkBurger : Burger
    {
        public PolishPorkBurger()
        {
            Name = "Polish Pork Burger";
            Roll = "White Roll";
            Meat = "Pulled Pork";
        }
    }

    internal class PolishWeggieBurger : Burger
    {
        public PolishWeggieBurger()
        {
            Name = "Polish Weggie Burger";
            Roll = "Whole Wheat Roll";
            Meat = "Veggie Patty";
        }
    }
}

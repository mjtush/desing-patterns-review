using BurgerStoreApp.FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerStoreApp.FactoryMethodPattern
{
    internal class TexasBurgerStore : BurgerStore
    {
        protected override Burger CreateBurger(string type) => type switch
        {
            "beef" => new TexasBeefBurger(),
            "chicken" => new TexasChickenBurger(),
            "pork" => new TexasPorkBurger(),
            "Veggie" => new TexasVeggieBurger(),
            _ => new TexasBeefBurger()
        };
    }

    internal class TexasBeefBurger : Burger
    {
        public TexasBeefBurger()
        {
            Name = "Texas Beef Burger";
            Roll = "White Roll";
            Meat = "Grilled Beef";
        }
    }

    internal class TexasChickenBurger : Burger
    {
        public TexasChickenBurger()
        {
            Name = "Texas Chicken Burger";
            Roll = "White Roll";
            Meat = "Grilled Chicken";
        }
    }

    internal class TexasPorkBurger : Burger
    {
        public TexasPorkBurger()
        {
            Name = "Texas Pork Burger";
            Roll = "White Roll";
            Meat = "Pork Patty";
        }
    }

    internal class TexasVeggieBurger : Burger
    {
        public TexasVeggieBurger()
        {
            Name = "Texas Veggie Burger";
            Roll = "Whole Wheat Roll";
            Meat = "Veggie Patty";
        }
    }
}

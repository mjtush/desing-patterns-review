using BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients
{
    public abstract class Meat
    {
        public string? Name { get; protected set; }
    }

    public class TexasBeef : Meat
    {
        public TexasBeef()
        {
            Name = "Texas Beef";
        }
    }

    public class TexasPork : Meat
    {
        public TexasPork()
        {
            Name = "Texas Pork";
        }
    }

    public class TexasChicken : Meat
    {
        public TexasChicken()
        {
            Name = "Texas Chicken";
        }
    }

    public class TexasVeggieMeat : Meat
    {
        public TexasVeggieMeat()
        {
            Name = "Texas Veggie Meat";
        }
    }

    public class PolishBeef : Meat
    {
        public PolishBeef()
        {
            Name = "Polish Beef";
        }
    }
    
    public class PolishPork : Meat
    {
        public PolishPork()
        {
            Name = "Polish Pork";
        }
    }

    public class PolishChicken : Meat
    {
        public PolishChicken()
        {
            Name = "Polish Chicken";
        }
    }

    public class PolishVeggieMeat : Meat
    {
        public PolishVeggieMeat()
        {
            Name = "Polish Veggie Meat";
        }
    }


}

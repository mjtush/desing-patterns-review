namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients;

public abstract class Roll
{
    public string? Name { get; protected set; }
}

public class WholeWheatRoll : Roll
{
    public WholeWheatRoll()
    {
        Name = "Hole Wheat Roll";
    }
}

public class WhiteRoll : Roll
{
    public WhiteRoll()
    {
        Name = "White Roll";
    }
}
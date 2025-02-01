namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory.Ingredients;

public abstract class Veggie
{
    public string? Name { get; protected set; }
}

public class Lettuce : Veggie
{
    public Lettuce()
    {
        Name = "Lettuce";
    }
}

public class Onion : Veggie
{
    public Onion()
    {
        Name = "Onion";
    }
}

public class Peakle : Veggie
{
    public Peakle()
    {
        Name = "Peakle";
    }
}

public class SourCucumber : Veggie
{
    public SourCucumber()
    {
        Name = "Sour Cucumber";
    }
}

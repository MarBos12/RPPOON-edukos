public interface Coffee
{
    double GetCost();
    String GetDescription();
}

public class Espresso : Coffee
{
    public double GetCost()
    {
        return 1.99;
    }

    public String GetDescription()
    {
        return "Espresso";
    }
}

public abstract class CoffeeDecorator : Coffee
{
    protected Coffee coffee;

    public CoffeeDecorator(Coffee coffee)
    {
        this.coffee = coffee;
    }
    public double GetCost()
    {
        return coffee.GetCost();
    }
    public string GetDescription()
    {
        return coffee.GetDescription();
    }
}

public class Milk : CoffeeDecorator
{
    public Milk(Coffee coffee) : base(coffee) { }

    public double GetCost()
    {
        return coffee.GetCost();
    }

    public string GetDescription()
    {
        return coffee.GetDescription()+"Milk";
    }
}
public static class ClientCode
{
    public static void Run()
    {
        Coffee Coffee = new Milk(new Espresso());
        Console.WriteLine("Description:" + Coffee.GetDescription());
        Console.WriteLine("Cost:$" + Coffee.GetCost());
    }
}

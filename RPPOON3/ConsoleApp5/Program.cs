
public interface IWizard
{
    void DoMagic();
}
public class FireWizard : IWizard
{
    public void DoMagic()
    {
        Console.WriteLine("Do Fire Magic");
    }
}

public class WaterWizard : IWizard
{
    public void DoMagic()
    {
        Console.WriteLine("Do Water Magic");
    }
}
public interface IGoblin
{
    void DoDamage();
}
public class FireGoblin : IGoblin
{
    public void DoDamage()
    {
        Console.WriteLine("Do Fire Damage");
    }
}

public class WaterGoblin : IGoblin
{
    public void DoDamage()
    {
        Console.WriteLine("Do Water Damage");
    }
}
public interface ILevelFactory
{
    IWizard CreateWizard();
    IGoblin CreateGoblin();
}

public class FireLevelFactory : ILevelFactory
{
    public IWizard CreateWizard()
    {
        return new FireWizard();
    }

    public IGoblin CreateGoblin()
    {
        return new FireGoblin();
    }
}

public class WaterLevelFactory : ILevelFactory
{
    public IWizard CreateWizard()
    {
        return new WaterWizard();
    }

    public IGoblin CreateGoblin()
    {
        return new WaterGoblin();
    }
}

public class GameManager
{
    private readonly ILevelFactory _levelFactory;
    public GameManager(ILevelFactory levelFactory)
    {
        _levelFactory = levelFactory;
    }
    public void PlayLevel()
    {
        IGoblin goblin = _levelFactory.CreateGoblin();
        IWizard wizard = _levelFactory.CreateWizard();
        goblin.DoDamage();
        wizard.DoMagic();
    }
}
class Program
{
    static void Main(string[] args)
    {
        ILevelFactory fireFactory = new FireLevelFactory();
        GameManager fireLevelManager = new GameManager(fireFactory);
        fireLevelManager.PlayLevel();

        ILevelFactory waterFactory = new WaterLevelFactory();
        GameManager waterLevelManager = new GameManager(waterFactory);
        waterLevelManager.PlayLevel();
    }
}



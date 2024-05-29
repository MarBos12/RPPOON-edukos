using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
//memento
public class Activity
{
    public int Price { get; set; }
    public string Name { get; set; }
    public Activity(string name)
    {
        Name = name;
    }
}
public class VacationConfigurator
{
    public string Destination { get; private set; }
    private List<Activity> additionalActivities = new List<Activity>();

    public decimal CalculateTotal()
    {
        return additionalActivities.Sum(it => it.Price);
    }

    public void AddExtra(Activity activity)
    {
        additionalActivities.Add(activity);
    }

    public void Remove(Activity activity)
    {
        additionalActivities.Remove(activity);
    }

    public void LoadPrevious(VacationConfiguration configuration)
    {
        Destination = configuration.GetDestination();
        additionalActivities.Clear();
        additionalActivities.AddRange(configuration.GetAdditionalActivities());
    }

    public VacationConfiguration Store()
    {
        return new VacationConfiguration(Destination, additionalActivities);
    }
}

public class VacationConfiguration
{
    private string destination;
    private List<Activity> additionalActivities;
    public VacationConfiguration(string destination, List<Activity> additionalActivities)
    {
        this.destination = destination;
        this.additionalActivities = new List<Activity>(additionalActivities);
    }

    public string GetDestination()
    {
        return destination;
    }

    public List<Activity> GetAdditionalActivities()
    {
        return new List<Activity>(additionalActivities);
    }
}

public class ConfigurationManager
{
    private List<VacationConfiguration> configurations = new List<VacationConfiguration>();

    public void AddConfiguration(VacationConfiguration configuration)
    {
        configurations.Add(configuration);
    }

    public void DeleteConfiguration(VacationConfiguration configuration)
    {
        configurations.Remove(configuration);
    }

    public VacationConfiguration GetConfiguration(int index)
    {
        return configurations[index];
    }
}

class Program
{
    public static void Main(string[] args)
    {
        VacationConfigurator vacationConfigurator = new VacationConfigurator();
        VacationConfiguration vacationConfiguration = vacationConfigurator.Store();
        ConfigurationManager configManager = new ConfigurationManager();
        configManager.AddConfiguration(vacationConfiguration);
        vacationConfigurator.LoadPrevious(configManager.GetConfiguration(0));
    }
}

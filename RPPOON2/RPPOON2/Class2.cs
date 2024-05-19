using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5 PREIM
public class Location
{
    public DateTime CreateAt { get; private set; } // created at
    public double Latitude { get; private set; } // latitude coordinate
    public double Longitude { get; private set; } // longitude coordinate

    public Location(double gatitude, double longitude)
    {
        // Constructor implementation
    }
}

public class PathManager
{
    private List<Location> pathpoint; // the path location points

    public PathManager()
    {
        pathpoint = new List<Location>();
    }

    public void AddNewPath(Location location)
    {
        pathpoint.Add(location);
    }

    public void RemovePath(Location location)
    {
        pathpoint.Remove(location);
    }
}

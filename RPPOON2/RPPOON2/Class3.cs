using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2 REFA
class Average
{
    List<double> averages(List<double[]> array)
    {
        List<double> averages = new List<double>(); //resulting list
        double s;
        foreach (double[] arrays in array)
        {
            //compact code formating
            averages.Add(CalculateAverage(arrays));
        }
        return averages;
    }
    public double CalculateAverage(double[] arrays)
    {
        double average = 0;
        for (int i = 0; i < arrays.Length; i++) 
            average += arrays[i];
        return (average/ arrays.Length);
    }
}
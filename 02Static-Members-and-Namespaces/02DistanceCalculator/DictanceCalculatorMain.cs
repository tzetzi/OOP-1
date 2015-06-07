using System;
using _01Point3D;

namespace DistanceCalculator
{
    public class DictanceCalculatorMain
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D( 1, 4, 1);
            Point3D point2 = new Point3D(-4, 10, 2);
            Console.WriteLine(DistanceCalculator.CalculateDistance(point1, point2)); 
        }
    }
}

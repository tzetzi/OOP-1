using System;
using _01Point3D;

namespace DistanceCalculator
{
    class DistanceCalculator
    {
       

      public static double CalculateDistance(Point3D first, Point3D second)
        {
            double result = Math.Sqrt(
          (second.X - first.X) * (second.X - first.X) +
          (second.Y - first.Y) * (second.Y - first.Y) +
          (second.Z - first.Z) * (second.Z - first.Z));
            return result;
        }
    }
}

using System;
using _01.Point3D;
using System.Collections.Generic;

namespace _03.Paths
{
    class Paths3DTest
    {
        static void Main(string[] args)
        {
            try
            {
                Point3D point1 = new Point3D(0, 5, 1);
                Point3D point2 = new Point3D(-3, 20, 0);
                Path3D path = new Path3D(new List<Point3D>() { point2, point1 });

                Storage.SavePathToFile("../../path.txt", path.ToString());
                Console.WriteLine("Load from file:\n" + Storage.LoadPathFromFile("../../path.txt"));
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

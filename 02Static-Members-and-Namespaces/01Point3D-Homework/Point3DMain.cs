using _01Point3D;
using System;

namespace _01Point3D
{
    class Point3DMain
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Start points:" + Point3D.Start); 
            
            Point3D firstPoint = new Point3D(2, 4, 1);

            Console.WriteLine("Current points:"+ firstPoint);
            
        }
    }
}

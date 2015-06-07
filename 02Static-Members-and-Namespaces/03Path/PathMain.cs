using _01Point3D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Path
{
    class PathMain
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1, 4, 1);
            Point3D point2 = new Point3D(-4, 10, 2);
            Point3D point3 = new Point3D(4, 1, 2);
            Point3D point4 = new Point3D();

            List<Point3D> list = new List<Point3D>() { point1, point2, point3 };
            Path3D path1 = new Path3D(list);

            Path3D path2 = new Path3D(new List<Point3D>() { point4, point1 });
            path2.AddPoint3D(point2);

            Path3D path3 = new Path3D(point4);
            path3.AddPoint3D(point1);

            Storage.SavePath("../../path.txt", path3);
            Path3D formStorage = Storage.LoadPath("../../path.txt");
            Console.WriteLine(formStorage);

        }
    }


}

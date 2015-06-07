using _01Point3D;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Path
{
   public class Path3D
     {
       //field 
       private List<Point3D> pointsInPath;
             
       //prop
        public List<Point3D> PointsInPath
       {
           get { return this.pointsInPath; }
           set { this.pointsInPath = value; }
       }

        //ctor - paramLess
        public Path3D()
        {
            //this.FisrtPoint = fisrtPoint;
        }
       
        //ctor - one points
       public Path3D(Point3D first)
       {
           List<Point3D> list = new List<Point3D>() {first};
           this.PointsInPath = list;
       }

       //ctor - more than one points
         public Path3D(List<Point3D> points)
        {
            this.pointsInPath = points;
        }


       //method
       public void AddPoint3D (Point3D new3dPoint)
       {
           if (pointsInPath==null)
           {
               List<Point3D> list = new List<Point3D>() {new3dPoint};
               this.pointsInPath = list;
               return;
           }
           this.pointsInPath.Add(new3dPoint);
       }


       //override
         public override string ToString()
         {
             
             StringBuilder sb = new StringBuilder();
             foreach (var item in pointsInPath)
             {
                 sb.Append(item+ " |");
             }
             return sb.ToString();
         }       
    }
}

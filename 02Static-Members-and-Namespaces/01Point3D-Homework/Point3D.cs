namespace _01Point3D
{
    public class Point3D
    {
        
        private static readonly Point3D start = new Point3D(0, 0, 0);

        //ctor
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Point3D()
        {

        }

        public static Point3D Start 
        {
            get { return start; }
        }


        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

       
        //method ovverride
        public override string ToString()
        {
            return string.Format("X:{0}, Y:{1}, Z:{2}", this.X,this.Y,this.Z);
        }
    }
}

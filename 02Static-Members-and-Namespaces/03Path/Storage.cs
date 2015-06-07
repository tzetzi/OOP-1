using _01Point3D;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Path
{
    class Storage
    {
        public static void SavePath(string pathAndName, Path3D path)
        {
            string json = JsonConvert.SerializeObject(path);

            StreamWriter writer = new StreamWriter(pathAndName, false, Encoding.GetEncoding("Windows-1251"));
            using (writer)
            {
                writer.WriteLine(json);
            }
        }

        public static Path3D LoadPath(string filepath)
        {
            string pattern = @"""X"":(-?\d+.\d+).*?""Y"":(-?\d+.\d+).*?""Z"":(-?\d+.\d+)";
            StreamReader reader = new StreamReader(filepath);
            Path3D formLoaded = new Path3D();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line!=null)
                {
                    Match readXYZ = Regex.Match(line, pattern);
                    while (readXYZ != null && readXYZ.Groups.Count==4)
                    {
                        double x = double.Parse(readXYZ.Groups[1].ToString());
                        double y = double.Parse(readXYZ.Groups[2].Value);
                        double z = double.Parse(readXYZ.Groups[3].ToString());
                        Point3D pointForAdd = new Point3D(x, y, z);
                        formLoaded.AddPoint3D(pointForAdd);
                        readXYZ = readXYZ.NextMatch();
                    }
                    
                    line = reader.ReadLine();
                }
            }
            return formLoaded;
        }
     }
}
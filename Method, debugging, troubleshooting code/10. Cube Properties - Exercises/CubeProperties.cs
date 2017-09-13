namespace _10.Cube_Properties___Exercises
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            double s = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if (type == "face")
            {
                Console.WriteLine(GetFaceOfCube(s));
            }
            else if (type == "space")
            {
                Console.WriteLine(GetSpaceOfCube(s));
            }
            else if (type == "volume")
            {
                Console.WriteLine(GetVolumeOfCube(s));
            }
            else if (type == "area")
            {
                Console.WriteLine(GetAreaOfCube(s));
            }
        }

        public static double GetVolumeOfCube(double s)
        {
            var volume = s * s * s;
            return Math.Round(volume, 2);
        }

        public static double GetAreaOfCube(double s)
        {
            var area = 6 * (s * s);
            return Math.Round(area, 2);
        }

        public static double GetFaceOfCube(double s)
        {
            var face = Math.Sqrt(2.0 * s * s);
            return Math.Round(face, 2);
        }

        public static double GetSpaceOfCube(double s)
        {
            var space = Math.Sqrt(3.0 * s * s);
            return Math.Round(space, 2);
        }
    }
}

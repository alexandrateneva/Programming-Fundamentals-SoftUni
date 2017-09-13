namespace _11.Geometry_Calculator___Exercises
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string typeOfFugure = Console.ReadLine();

            if (typeOfFugure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(PrintAreaOfTriangle(a,b));
            }
            else if (typeOfFugure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(PrintAreaOfSquare(a));
            }
            else if (typeOfFugure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(PrintAreaOfRectangle(a, b));
            }
            else if (typeOfFugure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(PrintAreaOfCircle(a));
            }

        }

        public static double PrintAreaOfTriangle(double a, double b)
        {
            var result = (a * b) / 2.0;
            return Math.Round(result, 2);
        }

        public static double PrintAreaOfSquare(double a)
        {
            var result = a * a;
            return Math.Round(result, 2);
        }

        public static double PrintAreaOfRectangle(double a, double b)
        {
            var result = a * b;
            return Math.Round(result, 2);
        }

        public static double PrintAreaOfCircle(double a)
        {
            var result = Math.PI * a * a;
            return Math.Round(result, 2);
        }
    }
}
    

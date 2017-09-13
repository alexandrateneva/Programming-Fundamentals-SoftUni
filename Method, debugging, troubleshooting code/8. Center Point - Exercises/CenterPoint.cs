namespace _8.Center_Point___Exercises
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(PrintClosestPoint(X1,Y1,X2,Y2));

        }

        public static string PrintClosestPoint (double X1, double Y1, double X2, double Y2)
        { 
            var distance1 = Math.Sqrt((X1 * X1) + (Y1 * Y1));
            var distance2 = Math.Sqrt((X2 * X2) + (Y2 * Y2));
            string result = null;

            if (distance1 <= distance2)
            {
                result = $"({X1}, {Y1})";
            }
            else if (distance2 < distance1)
            {
                result = $"({X2}, {Y2})";
            }

            return result;
        }
    }
}

namespace _9.Longer_Line___Exercises
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());

            Console.WriteLine(PrintClosestPoint(X1, Y1, X2, Y2, X3, Y3, X4, Y4));

        }

        public static string PrintClosestPoint(double X1, double Y1, double X2, double Y2,
                                               double X3, double Y3, double X4, double Y4)
        {
            double line1 = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            double line2 = Math.Sqrt(Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2));

            string result = null;

            if (line1 >= line2)
            {
                double point1 = Math.Sqrt(Math.Pow((X1), 2) + Math.Pow((Y1), 2));
                double point2 = Math.Sqrt(Math.Pow((X2), 2) + Math.Pow((Y2), 2));

                bool isFirstCloser = point1 <= point2;

                if (isFirstCloser)
                {
                    result = $"({X1}, {Y1})({X2}, {Y2})";
                }
                else
                {
                    result = $"({X2}, {Y2})({X1}, {Y1})";
                }
            }
            else if (line2 >= line1)
            {
                double point1 = Math.Sqrt(Math.Pow((X3), 2) + Math.Pow((Y3), 2));
                double point2 = Math.Sqrt(Math.Pow((X4), 2) + Math.Pow((Y4), 2));

                bool isFirstCloser = point1 <= point2;

                if (isFirstCloser)
                {
                    result = $"({X3}, {Y3})({X4}, {Y4})";
                }
                else
                {
                    result = $"({X4}, {Y4})({X3}, {Y3})";
                }
            }

            return result;
        }
    }
}

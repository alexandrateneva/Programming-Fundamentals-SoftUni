namespace _12.Rectangle_Properties___Exercises
{
    using System;

    public class RectangleProperties
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(a * 2 + b * 2);
            Console.WriteLine(a * b);
            Console.WriteLine(Math.Sqrt(a * a + b * b));
        }
    }
}

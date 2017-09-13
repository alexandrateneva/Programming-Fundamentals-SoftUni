namespace _06.Point_on_Rectangle_Border
{
    using System;

    public class PointOnRectangleBorder
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            if ((x2 == x || x == x1) && (y2 >= y && y >= y1) ||
               (y2 == y || y == y1) && (x2 > x && x > x1))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}

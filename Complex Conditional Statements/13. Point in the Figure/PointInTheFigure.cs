namespace _13.Point_in_the_Figure
{
    using System;

    public class PointInTheFigure
    {
        public static void Main()
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if ((x > 0 && x < 3 * h) && (y > 0 && y < h) || (x > h && x < 2 * h) && (y >= h && y < 4 * h))
            {
                Console.WriteLine("inside");
            }
            else if ((y == 0 && (x >= 0 && x <= 3 * h)) || (y == h && (x >= 0 && x <= h)) || (y == h && (x >= h * 2 && x <= h * 3)) || (y == h * 4 && (x >= h && x <= h * 2)))
            {
                Console.WriteLine("border");
            }
            else if ((x == 0 && (y >= 0 && y <= h)) || (x == h && (y >= h && y <= 4 * h)) || (x == h * 2 && (y >= h && y <= 4 * h)) || (x == h * 3 && (y >= 0 && y <= h)))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}

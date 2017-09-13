namespace _6.Rectangle_Position___Lab
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            var coordinatesFirstRectangle = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var coordinatesSecondRectangle = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var firstRect = new Rectangle
            {
                left = coordinatesFirstRectangle[0],
                top = coordinatesFirstRectangle[1],
                width = coordinatesFirstRectangle[2],
                height = coordinatesFirstRectangle[3]
            };
            var secondRect = new Rectangle
            {
                left = coordinatesSecondRectangle[0],
                top = coordinatesSecondRectangle[1],
                width = coordinatesSecondRectangle[2],
                height = coordinatesSecondRectangle[3]
            };
            if (firstRect.left >= secondRect.left && firstRect.top >= secondRect.top
                && firstRect.bottom >= secondRect.bottom && firstRect.right <= secondRect.right)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}

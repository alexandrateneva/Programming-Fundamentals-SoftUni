namespace _4.Distance_between_Points___Lab
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var secondPointCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point firstPoint = new Point
            {
                X = firstPointCoordinates[0],
                Y = firstPointCoordinates[1]
            };

            Point secondPoint = new Point
            {
                X = secondPointCoordinates[0],
                Y = secondPointCoordinates[1]
            };

            var diffX = Math.Pow((firstPoint.X - secondPoint.X), 2);
            var diffY = Math.Pow((firstPoint.Y - secondPoint.Y), 2);
            var distance = Math.Sqrt(diffX + diffY);

            Console.WriteLine($"{distance:F3}");
        }
    }
}

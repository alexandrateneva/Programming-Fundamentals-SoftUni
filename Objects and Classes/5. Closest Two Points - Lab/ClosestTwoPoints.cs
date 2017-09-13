namespace _5.Closest_Two_Points___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var listOfPoints = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var coordinatesOfPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                var currentPoint = new Point
                {
                    X = coordinatesOfPoint[0],
                    Y = coordinatesOfPoint[1]
                };
                listOfPoints.Add(currentPoint);
            }
            var minDistance = double.MaxValue;
            var closestFirstPoint = new Point();
            var closestSecondPoint = new Point();
            for (int i = 0; i < listOfPoints.Count -1; i++)
            {
                for (int j = i+1; j < listOfPoints.Count; j++)
                {
                    var diffX = Math.Pow((listOfPoints[i].X - listOfPoints[j].X), 2);
                    var diffY = Math.Pow((listOfPoints[i].Y - listOfPoints[j].Y), 2);
                    var distance = Math.Sqrt(diffX + diffY);

                    if (distance<minDistance)
                    {
                        minDistance = distance;
                        closestFirstPoint = listOfPoints[i];
                        closestSecondPoint = listOfPoints[j];
                    }
                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({closestFirstPoint.X}, {closestFirstPoint.Y})");
            Console.WriteLine($"({closestSecondPoint.X}, {closestSecondPoint.Y})");
        }
    }
}

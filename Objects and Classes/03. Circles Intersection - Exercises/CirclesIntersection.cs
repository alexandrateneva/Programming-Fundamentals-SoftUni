namespace _03.Circles_Intersection___Exercises
{
   using System;

    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstCircleInfo = Console.ReadLine().Split(' ');
            var secondCircleInfo = Console.ReadLine().Split(' ');

            var firstCircleRadius = double.Parse(firstCircleInfo[2]);
            var secondCircleRadius = double.Parse(secondCircleInfo[2]);

            var firstCircleCenter = new Point
            {
                X = double.Parse(firstCircleInfo[0]),
                Y = double.Parse(firstCircleInfo[1])
            };

            var secondCircleCenter = new Point
            {
                X = double.Parse(secondCircleInfo[0]),
                Y = double.Parse(secondCircleInfo[1])
            };

            var diffX = Math.Pow((firstCircleCenter.X - secondCircleCenter.X), 2);
            var diffY = Math.Pow((firstCircleCenter.Y - secondCircleCenter.Y), 2);
            var distance = Math.Sqrt(diffX + diffY);

            if (distance <= firstCircleRadius + secondCircleRadius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

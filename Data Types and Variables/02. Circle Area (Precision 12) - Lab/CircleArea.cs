namespace _02.Circle_Area__Precision_12____Lab
{
    using System;

    public class CircleArea
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f12}", (Math.PI * radius * radius));
        }
    }
}

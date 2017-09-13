namespace _16.Comparing_floats___Exercises
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            if (Math.Abs(number1 - number2) > 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}

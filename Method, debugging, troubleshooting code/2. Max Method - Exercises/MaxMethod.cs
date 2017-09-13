namespace _2.Max_Method___Exercises
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int biggerNumber = GetMax(a, b);
            int biggestNumber = GetMax(biggerNumber, c);
            Console.WriteLine(biggestNumber);

        }

        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}

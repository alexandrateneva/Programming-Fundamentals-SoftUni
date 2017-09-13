namespace _07.Greatest_Common_Divisor__CGD_
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var big = Math.Max(a, b);
            var small = Math.Min(a, b);
            var remainder = 1;

            for (int i = 0; remainder != 0; i++)
            {
                remainder = big % small;
                big = small;
                small = remainder;
            }

            Console.WriteLine(big);
        }
    }
}

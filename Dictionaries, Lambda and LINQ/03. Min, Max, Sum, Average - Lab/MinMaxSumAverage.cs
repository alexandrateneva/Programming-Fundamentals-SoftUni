namespace _03.Min__Max__Sum__Average___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}

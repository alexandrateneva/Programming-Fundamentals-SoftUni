namespace _01.Convert_from_base_10_to_base_N___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            var baseN = input[0];
            var number = input[1];
            var result = new List<BigInteger>();

            while (true)
            {
                var num = number / baseN;
                var remainder = number % baseN;
                result.Add(remainder);
                number = num;
                if (num == 0)
                {
                    break;
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}

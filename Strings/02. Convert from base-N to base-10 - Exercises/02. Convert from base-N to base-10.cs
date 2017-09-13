namespace _02.Convert_from_base_N_to_base_10___Exercises
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
            var number = input[1].ToString().ToCharArray();
            BigInteger sum = 0;
            var num = new List<BigInteger>();
            foreach (var digit in number)
            {
                num.Add(new BigInteger(char.GetNumericValue(digit)));
            }
            num.Reverse();
            for (int i = 0; i < num.Count; i++)
            {
                sum += num[i] * BigInteger.Pow(baseN, i);
            }
            Console.WriteLine(sum);
        }
    }
}

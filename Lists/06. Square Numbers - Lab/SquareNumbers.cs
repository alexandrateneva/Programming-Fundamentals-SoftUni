namespace _06.Square_Numbers___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    squareNumbers.Add(numbers[i]);
                }
            }

            //squareNumbers.Sort();
            //squareNumbers.Reverse();

            squareNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}

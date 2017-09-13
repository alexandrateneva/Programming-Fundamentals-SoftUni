namespace _03.Equal_Sums___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var leftSum = 0;
            var rightSum = 0;
            var existNum = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                var leftNumbers = numbers.Take(i).ToList();
                var rightNumbers = numbers.Skip(i + 1).ToList();
                leftSum = leftNumbers.Sum();
                rightSum = rightNumbers.Sum();
                if (rightSum == leftSum)
                {
                    Console.WriteLine(numbers.IndexOf(numbers.First(x => x == numbers[i])));
                    existNum = true;
                }
            }
            if (existNum == false)
            {
                Console.WriteLine("no");
            }

        }
    }
}

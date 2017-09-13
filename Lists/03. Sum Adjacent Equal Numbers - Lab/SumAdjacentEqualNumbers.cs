namespace _03.Sum_Adjacent_Equal_Numbers___Lab
{
    using System;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    numbers[i] = numbers[i] * 2;
                    numbers.Remove(numbers[i - 1]);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

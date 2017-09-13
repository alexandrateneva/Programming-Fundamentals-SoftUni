namespace _1.Max_Sequence_of_Equal_Elements___Exercises
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var num = 0;
            var count = 1;
            var maxCount = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        num = numbers[i];
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            if (maxCount == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int j = 0; j < Math.Max(maxCount, count); j++)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}

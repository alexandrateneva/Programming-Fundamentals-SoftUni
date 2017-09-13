namespace _6.Max_Sequence_of_Equal_Elements___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxNumbers = 0;
            int firstCounter = 1;
            int maxCounter = 1;
            int pos = 0;

            while (pos < numbers.Count - 1)
            {
                if (numbers[pos] == numbers[pos + 1])
                {
                    firstCounter++;

                    if (firstCounter > maxCounter)
                    {
                        maxCounter = firstCounter;
                        maxNumbers = numbers[pos];
                    }
                }
                else
                {
                    firstCounter = 1;
                }
                pos++;

                if (maxCounter == 1)
                {
                    maxNumbers = numbers[0];
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(maxNumbers);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

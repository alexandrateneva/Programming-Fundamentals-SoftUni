namespace _04.Max_Sequence_of_Equal_Elements___Exercises
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counter = 1;
            var maxCounter = 1;
            var num = 0;
            var existSeq = false;

            if (numbers.Count == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        counter++;
                        existSeq = true;
                    }
                    if (counter > maxCounter)
                    {
                        num = numbers[i];
                        maxCounter = counter;
                    }
                    if (numbers[i] != numbers[i + 1])
                    {
                        counter = 1;
                    }
                }
                if (existSeq == true)
                {
                    for (int i = 0; i < maxCounter; i++)
                    {
                        Console.Write($"{num} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
        }
    }
}

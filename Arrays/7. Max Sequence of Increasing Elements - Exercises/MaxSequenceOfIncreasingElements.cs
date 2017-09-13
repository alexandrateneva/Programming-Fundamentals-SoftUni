namespace _7.Max_Sequence_of_Increasing_Elements___Exercises
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] sequance = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int maxStart = 0;
            int maxLength = 1;
            int currentStart = 0;
            int currentLength = 1;

            for (int i = 1; i < sequance.Length; i++)
            {
                if (sequance[i] > sequance[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }
            }
            for (int i = maxStart; i < maxStart + maxLength; i++)
                Console.Write("{0} ", sequance[i]);
        }
    }
}

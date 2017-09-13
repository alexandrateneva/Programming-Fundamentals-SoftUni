namespace _10.Pairs_by_Difference___Exercises
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i; k < numbers.Length; k++)
                {
                    if (Math.Abs(numbers[k] - numbers[i]) == n && i < k)
                    {
                        //Console.WriteLine(numbers[i] + " " + numbers[k]);
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);

        }
    }
}

namespace _07.Sum_Arrays___Lab
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();

            var numbers1 = text1.Split(' ').Select(int.Parse).ToArray();
            var numbers2 = text2.Split(' ').Select(int.Parse).ToArray();

            var resultLength = Math.Max(numbers1.Length, numbers2.Length);
            var sum = 0;

            for (int i = 0; i < resultLength; i++)
            {
                if (numbers1.Length > numbers2.Length)
                {
                    sum = numbers1[i] + numbers2[i % numbers2.Length];
                    Console.Write($"{sum} ");
                }
                else if (numbers1.Length < numbers2.Length)
                {
                    sum = numbers1[i % numbers1.Length] + numbers2[i];
                    Console.Write($"{sum} ");
                }
                else
                {
                    sum = numbers1[i] + numbers2[i];
                    Console.Write($"{sum} ");
                }
            }

            Console.WriteLine();

        }
    }
}

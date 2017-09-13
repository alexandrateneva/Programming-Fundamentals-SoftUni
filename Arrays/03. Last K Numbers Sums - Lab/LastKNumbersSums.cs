namespace _03.Last_K_Numbers_Sums___Lab
{
    using System;

    public class LastKNumbersSums
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                long sum = 0;
                for (int prev = i - k; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += numbers[prev];
                    }
                    numbers[i] = sum;
                }
            }

            var result = string.Join(" ", numbers);
            Console.WriteLine(result);
        }
    }
}
namespace _03.Exact_Sum_of_Real_Numbers___Lab
{
    using System;

    public class ExtractSumOfRealNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}

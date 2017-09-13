namespace _09.Sum_Digits
{
    using System;

    public class SumDigits
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; n > 0; i++)
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
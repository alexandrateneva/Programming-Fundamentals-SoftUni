namespace _05.Max_Number
{
    using System;

    public class MaxNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var max = -1000000000;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}

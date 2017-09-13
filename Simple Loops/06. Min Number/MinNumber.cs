namespace _06.Min_Number
{
    using System;

    public class MinNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = 10000000;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}

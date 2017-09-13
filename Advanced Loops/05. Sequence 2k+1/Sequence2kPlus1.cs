namespace _05.Sequence_2k_1
{
    using System;

    public class Sequence2kPlus1
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int i = 1; num <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}

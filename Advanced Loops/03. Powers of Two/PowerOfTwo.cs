namespace _03.Powers_of_Two
{
    using System;

    public class PowerOfTwo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}

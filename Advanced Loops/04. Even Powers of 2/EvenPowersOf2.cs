namespace _04.Even_Powers_of_2
{
    using System;

    public class EvenPowersOf2
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 1; i <= n / 2 + 1; i++)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;
            }
        }
    }
}

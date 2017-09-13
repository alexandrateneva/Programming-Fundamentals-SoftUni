namespace _12.Fibonacci
{
    using System;

    public class Fibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;
            var fNext = 0;

            for (int i = 1; i < n; i++)
            {
                fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            if (n < 2)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(f1);
            }
        }
    }
}

namespace _08.Factorial
{
    using System;

    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 1; 1 < n; i++)
            {
                num = num * n;
                n--;
            }
            Console.WriteLine(num);
        }
    }
}

namespace _10.Check_Prime
{
    using System;

    public class CheckPrime
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var result = 0;
            var prime = true;

            for (int num = 2; num < n; num++)
            {
                result = n % num;
                if (result == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime && n > 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}

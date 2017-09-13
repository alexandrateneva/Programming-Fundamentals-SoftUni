namespace _6.Prime_Checker___Exercises
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        public static bool IsPrime(long number)
        {

            if (number <= 1)
            {
                return false;
            }
            else if (number > 2)
            {
                for (int i = 2; i <= (int)Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}


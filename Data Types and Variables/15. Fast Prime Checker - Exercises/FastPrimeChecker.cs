namespace _15.Fast_Prime_Checker___Exercises
{
    using System;

    public class FastPrimeChecker
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool result = true;
                for (int devisor = 2; devisor <= Math.Sqrt(number); devisor++)
                {
                    if (number % devisor == 0)
                    {
                        result = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {result}");
            }

        }
    }
}

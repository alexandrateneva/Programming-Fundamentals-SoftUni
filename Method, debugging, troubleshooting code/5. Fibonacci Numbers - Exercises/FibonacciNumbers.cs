namespace _5.Fibonacci_Numbers___Exercises
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumber(n));
        }

        public static long GetFibonacciNumber(long n)
        {
            long firstNumber = 1;
            long secondNumber = 1;
            long sum = 0;
            for (int i = 1; i < n; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
            return secondNumber;
        }
    }
}


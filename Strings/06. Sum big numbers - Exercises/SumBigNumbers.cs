namespace _06.Sum_big_numbers___Exercises
{
    using System;
    using System.Numerics;

   public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNumber = BigInteger.Parse(Console.ReadLine());
            var secondNumber = BigInteger.Parse(Console.ReadLine());
            var sum = firstNumber + secondNumber;
            Console.WriteLine(sum);
        }
    }
}

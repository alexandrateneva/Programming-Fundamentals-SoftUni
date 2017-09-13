namespace _07.Multiply_big_number___Exercises
{
    using System;
    using System.Numerics;

    public class MultiplyBigNumbers
    {
        public static void Main()
        {
            var firstNumber = BigInteger.Parse(Console.ReadLine());
            var secondNumber = BigInteger.Parse(Console.ReadLine());
            var result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }
    }
}

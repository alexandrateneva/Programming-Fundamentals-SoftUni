namespace _14.Factorial_Trailing_Zeroes___Exercises
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(GetTrailingZeros(factorial));

        }

        public static BigInteger GetTrailingZeros(BigInteger factorial)
        {
            var number = factorial.ToString().ToCharArray();
            var reversedNumber = number.Reverse();
            var arrReversedNumber = reversedNumber.ToArray();
            var numberOfZeros = 0;

            for (int i = 0; i < arrReversedNumber.Length; i++)
            {
                var nextZero = true;
                if (arrReversedNumber[i] == '0' && nextZero == true)
                {
                    numberOfZeros++;
                }
                if (arrReversedNumber[i] != '0')
                {
                    nextZero = false;
                    return numberOfZeros;
                }
            }
            return numberOfZeros;
        }
    }
}

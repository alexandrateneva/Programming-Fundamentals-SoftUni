namespace _08.Multiply_Evens_by_Odds___Lab
{
    using System;

    public class MultiplyEventsByOdds
    {
        public static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            return GetSumOfEvens(number) * GetSumOfOdds(number);
        }

        static int GetSumOfEvens(int number)
        {
            return GetSumOfDigits(number, 0);
        }

        static int GetSumOfOdds(int number)
        {

            return GetSumOfDigits(number, 1);
        }

        public static int GetSumOfDigits(int number, int remainder)
        {
            int sum = 0;

            foreach (var symbol in number.ToString())
            {
                var lastDigit = symbol - '0';
                if (lastDigit % 2 == remainder)
                {
                    sum += lastDigit;
                }

            }
            return sum;
        }

    }
}

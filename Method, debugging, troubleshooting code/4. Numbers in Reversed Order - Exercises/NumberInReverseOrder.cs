namespace _4.Numbers_in_Reversed_Order___Exercises
{
    using System;

    public class NumberInReverseOrder
    {
        public static void Main()
        {
            //string input = Console.ReadLine();
            //Console.WriteLine(string.Join("", input.Reverse()));

            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(GetDigitsInReversedOrder(number));
        }

        public static string GetDigitsInReversedOrder(decimal number)
        {
            decimal lastDigit = 0m;
            string stringSumOfDigits = null;
            string str = number.ToString().Replace(".", string.Empty);
            decimal number2 = decimal.Parse(str);
            var zeros = number2 / number;

            while (number2 > 0)
            {
                lastDigit = number2 % 10;
                number2 = (long)number2 / 10;
                stringSumOfDigits += (lastDigit.ToString());
            }
            return stringSumOfDigits;
        }
    }
}


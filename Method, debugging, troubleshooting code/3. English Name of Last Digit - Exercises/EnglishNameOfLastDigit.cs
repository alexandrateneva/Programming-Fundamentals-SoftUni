namespace English_Name_Of_The_Last_Digit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(GetNameOfLastDigit(number));
        }

        private static string GetNameOfLastDigit(long number)
        {
            long lastDigit = Math.Abs(number % 10);

            string nameOfDigit = null;
            switch (lastDigit)
            {
                case 0: nameOfDigit = "zero"; break;
                case 1: nameOfDigit = "one"; break;
                case 2: nameOfDigit = "two"; break;
                case 3: nameOfDigit = "three"; break;
                case 4: nameOfDigit = "four"; break;
                case 5: nameOfDigit = "five"; break;
                case 6: nameOfDigit = "six"; break;
                case 7: nameOfDigit = "seven"; break;
                case 8: nameOfDigit = "eight"; break;
                case 9: nameOfDigit = "nine"; break;
            }
            return nameOfDigit;
        }
    }
}
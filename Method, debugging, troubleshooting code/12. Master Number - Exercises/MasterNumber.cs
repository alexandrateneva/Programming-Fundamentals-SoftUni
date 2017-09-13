namespace _12.Master_Number___Exercises
{
    using System;
    using System.Linq;

    public class MasterNumber
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                var numbersArray = i.ToString().ToCharArray();

                if (SumOfDigits(i) == true && ContainsEvenDigit(i) == true
                    && IsPalindrome(numbersArray) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(char[] numbersArray)
        {
            var newNumber = numbersArray.Reverse();
            if (newNumber.SequenceEqual(numbersArray))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SumOfDigits(int number)
        {

            var sumOfDigits = 0;
            var numbersArray2 = number.ToString();
            for (int i = 0; i < numbersArray2.Length; i++)
            {
                sumOfDigits += int.Parse(numbersArray2[i].ToString());
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }


        public static bool ContainsEvenDigit(int number)
        {
            var counter = 0;
            string numbersArray2 = number.ToString();
            for (int i = 0; i < numbersArray2.Length; i++)
            {
                int currentDigit = int.Parse(numbersArray2[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    counter++;
                }
            }
            if (counter > 0)
            {
                return true;
            }
            return false;
        }
    }
}

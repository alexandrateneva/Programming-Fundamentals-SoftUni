namespace _05.Special_Numbers___Lab
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                var sum = 0;
                var newNumber = number;
                var digit = 0;

                while (newNumber > 0)
                {
                    digit = newNumber % 10;
                    newNumber = newNumber / 10;
                    sum += digit;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", number);
                }
                else
                {
                    Console.WriteLine("{0} -> False", number);
                }
            }
        }
    }
}

namespace _02.Reverse_Array_of_Integers___Lab
{
    using System;

    public class ReverseArrayOfInteger
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

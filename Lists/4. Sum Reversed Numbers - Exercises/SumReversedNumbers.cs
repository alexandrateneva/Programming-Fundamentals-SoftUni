namespace _4.Sum_Reversed_Numbers___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            List<int> reversedNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string eachElement = numbers[i];
                char[] element = eachElement.ToCharArray();
                char[] reversed = element.Reverse().ToArray();
                reversedNumbers.Add(int.Parse(string.Join("", reversed)));
            }
            Console.WriteLine(reversedNumbers.Sum());
        }
    }
}

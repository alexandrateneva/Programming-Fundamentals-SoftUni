namespace _5.Rounding_Numbers___Lab
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var numbers = input.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                var newNembers = Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {newNembers}");
            }
        }
    }
}

namespace _09.Extract_Middle_Elements___Lab
{
    using System;
    using System.Linq;

    public class ExtractMiddleElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            GetMiddleElements(numbers);
        }

        public static void GetMiddleElements(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                Console.WriteLine("{ " + $"{numbers[0]}" + " }");
            }
            else if (numbers.Length % 2 != 0)
            {
                Console.WriteLine("{ " + $"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]}" + " }");
            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine("{ " + $"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}" + " }");
            }
        }
    }
}

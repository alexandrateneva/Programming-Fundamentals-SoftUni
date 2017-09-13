namespace _08.Condense_Array_to_Number___Lab
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var condense = new int[numbers.Length - 1];

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < condense.Length - i; j++)
                {
                    condense[j] = numbers[j] + numbers[j + 1];
                }

                numbers = condense;
            }
            Console.WriteLine(condense[0]);
        }
    }
}

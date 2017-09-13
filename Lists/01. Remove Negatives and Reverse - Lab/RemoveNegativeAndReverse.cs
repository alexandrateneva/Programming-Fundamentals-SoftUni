namespace _01.Remove_Negatives_and_Reverse___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativeAndReverse
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.RemoveAll(x => x < 0);

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

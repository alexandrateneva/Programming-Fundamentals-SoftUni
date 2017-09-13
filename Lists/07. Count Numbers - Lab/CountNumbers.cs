namespace _07.Count_Numbers___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class CountNumbers
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = 0;
            var allSingleNumbers = GetSingleNumbers(numbers);

            for (int i = 0; i < allSingleNumbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (allSingleNumbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{allSingleNumbers[i]} -> {count}");
                count = 0;
            }
        }

        public static List<int> GetSingleNumbers(List<int> n)
        {
            List<int> singleNumbers = new List < int > (n);
            singleNumbers.Sort();
            int index = 0;
            while (index < singleNumbers.Count - 1)
            {
                if (singleNumbers[index] == singleNumbers[index + 1])
                {
                    singleNumbers.RemoveAt(index);
                }
                else
                {
                    index++;
                }
            }
            return singleNumbers;
        }
    }
}

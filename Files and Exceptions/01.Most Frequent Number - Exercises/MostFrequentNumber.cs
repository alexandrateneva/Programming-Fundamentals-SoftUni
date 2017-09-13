namespace _01.Most_Frequent_Number___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var freqNum = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!freqNum.ContainsKey(numbers[i]))
                {
                    freqNum[numbers[i]] = 1;
                }
                else
                {
                    freqNum[numbers[i]]++;
                }
            }
            var result = freqNum.FirstOrDefault(x => x.Value == freqNum.Values.Max()).Key;
            Console.WriteLine(result);
        }
    }
}

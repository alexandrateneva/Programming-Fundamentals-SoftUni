namespace _02.Append_Lists___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();

            numbers.Reverse();

            List<string> result = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var num = numbers[i];
                List<string> nums = num.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

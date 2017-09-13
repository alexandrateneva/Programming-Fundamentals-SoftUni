namespace _02.Odd_Occurrences___Lab
{
    using System;
    using System.Collections.Generic;

    public class OddOccurences
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 0;
                }
                counts[word]++;
            }

            var result = new List<string>();
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}

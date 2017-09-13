namespace _4.Palindromes___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palidromes
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();
            foreach (var word in words)
            {
                var reversedWord = word.Reverse();
                if (string.Compare(word, string.Join("", reversedWord), false) == 0)
                {
                    result.Add(word);
                }
            }
            var sortedResult = result.Distinct().OrderBy(n => n).ToList();
            Console.WriteLine(string.Join(", ", sortedResult));
        }
    }
}

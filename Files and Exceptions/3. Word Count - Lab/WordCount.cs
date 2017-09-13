namespace _3.Word_Count___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText(@"../../words.txt").Split(' ').Select(w => w.ToLower()).Distinct().ToArray();
            var textInWords = File.ReadAllText(@"../../text.txt").Split(new char[] { ' ', ',', '.', '-', '?', '!', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToArray();
            var wordFrequence = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var counter = 0;
                for (int j = 0; j < textInWords.Length; j++)
                {
                    if (words[i] == textInWords[j])
                    {
                        counter++;
                    }
                }
                wordFrequence[words[i]] = counter;
            }
            var result = wordFrequence
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToArray();

            File.WriteAllLines(@"../../output.txt", result);
        }
    }
}

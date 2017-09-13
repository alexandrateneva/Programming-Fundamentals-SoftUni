namespace _02.Extract_sentences_by_keyword___Exercises
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentncesByKeyword
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex("\\b" + word + "\\b");
            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}

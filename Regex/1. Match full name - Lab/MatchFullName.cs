namespace _1.Match_full_name___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b");

            var matches = regex.Matches(text);
            Console.WriteLine(matches.Count);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}

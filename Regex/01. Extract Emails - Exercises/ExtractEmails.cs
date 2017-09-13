namespace _01.Extract_Emails___Exercises
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"([\w-.]+@[A-Za-z-]+)(\.[A-Za-z-]+)+");
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string matchString = match.ToString();
                if (!(matchString.StartsWith("-") || matchString.StartsWith("_") || matchString.StartsWith(".") ||
                    matchString.EndsWith("-") || matchString.EndsWith("_") || matchString.EndsWith(".")))
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}

namespace _05.Use_Your_Chains__Buddy
{
    using System;
    using System.Text.RegularExpressions;

    public class UseYourChains
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var replace = @"[^a-z0-9]+";
            var regex = new Regex(@"<p>(.+?)<\/p>");
            var removeSpace = new Regex(@"(\s{2,})+");
            var matches = regex.Matches(input);
            string finalResult = null;
            foreach (Match match in matches)
            {
                var currentMatch = match.Groups[1].Value;
                var result = Regex.Replace(currentMatch, replace, " ");

                for (int i = 0; i < result.Length; i++)
                {
                    if ((int)result[i] >= 97 && (int)result[i] <= 109)
                    {
                        var newLetter = (char)((int)result[i] + 13);
                        result = result.Remove(i, 1).Insert(i, newLetter.ToString());
                    }
                    else if ((int)result[i] >= 110 && (int)result[i] <= 122)
                    {
                        var newLetter = (char)((int)result[i] - 13);
                        result = result.Remove(i, 1).Insert(i, newLetter.ToString());
                    }
                }
                finalResult = string.Concat(finalResult, result);
            }
            var output = removeSpace.Replace(finalResult, " ");
            Console.WriteLine(output);
        }
    }
}
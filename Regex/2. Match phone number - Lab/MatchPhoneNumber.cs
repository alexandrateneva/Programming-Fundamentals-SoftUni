namespace _2.Match_phone_number___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex1 = new Regex(@"(\+359 \d{1} \d{3} \d{4})\b");
            var regex2 = new Regex(@"(\+359-\d{1}-\d{3}-\d{4})\b");
            var matches1 = regex1.Matches(text);
            var matches2 = regex2.Matches(text);
            var sum = matches1.Count + matches2.Count;
            Console.WriteLine(sum);
            foreach (Match match in matches1)
            {
                Console.WriteLine(match);
            }
            foreach (Match match in matches2)
            {
                Console.WriteLine(match);
            }
        }
    }
}

namespace _04.Query_Mess___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string pattern = @"([^&=?]*)=([^&=]*)";
            string regex = @"((%20|\+)+)";
            string input = null;

            while (!((input = Console.ReadLine()) == "END"))
            {
                var pairs = new Regex(pattern);
                var matches = pairs.Matches(input);

                var results = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, regex, " ").Trim();

                    string value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, regex, " ").Trim();

                    if (!results.ContainsKey(field))
                    {
                        var values = new List<string>();
                        values.Add(value);
                        results.Add(field, values);
                    }
                    else
                    {
                        results[field].Add(value);
                    }
                }
                foreach (var pair in results)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();
            }
        }
    }
}

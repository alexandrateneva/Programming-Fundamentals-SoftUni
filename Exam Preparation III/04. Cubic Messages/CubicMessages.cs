namespace _04.Cubic_Messages
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            while (true)
            {
                var text = Console.ReadLine();

                if (text == "Over!")
                {
                    break;
                }
                var number = int.Parse(Console.ReadLine());
                var pattern = $@"^(\d+)([a-zA-Z]{{{number}}})([^a-zA-Z]*)$";
                var regex = new Regex(pattern);
                var match = regex.Match(text);

                if (match.Success)
                {
                    var symbols = match.Groups[2].Value.ToCharArray().ToList();
                    var message = match.Groups[2].Value;
                    var allDigits = string.Concat(match.Groups[1].Value, match.Groups[3].Value)
                        .Where(char.IsDigit)
                        .Select(d => d - '0');
                    var result = new StringBuilder();
                    foreach (var digit in allDigits)
                    {
                        if (digit < 0 || digit >= symbols.Count)
                        {
                            result.Append(' ');
                        }
                        else
                        {
                            result.Append(symbols[digit]);
                        }
                    }

                    Console.WriteLine($"{message} == {result}");
                }
            }
        }
    }
}

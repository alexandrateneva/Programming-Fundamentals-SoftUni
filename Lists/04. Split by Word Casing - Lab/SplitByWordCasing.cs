namespace _04.Split_by_Word_Casing___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"',
                '\\', '/', '[', ']',' ', '\'' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            foreach (var word in text)
            {
                if (word.All(char.IsUpper))
                {
                    upperCase.Add(word);
                }
                else if (word.All(char.IsLower))
                {
                    lowerCase.Add(word);
                }
                else /*(word.Any(char.IsLower) && word.Any(char.IsUpper)) and any symbols*/
                {
                    mixedCase.Add(word);
                }
            }
            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCase));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upperCase));
        }
    }
}

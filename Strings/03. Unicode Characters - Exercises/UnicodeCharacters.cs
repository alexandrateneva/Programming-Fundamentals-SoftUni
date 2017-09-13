namespace _03.Unicode_Characters___Exercises
{
    using System;
    using System.Collections.Generic;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var result = new List<string>();

            foreach (var symbol in input)
            {
                result.Add("\\u" + ((int)symbol).ToString("x4"));
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}

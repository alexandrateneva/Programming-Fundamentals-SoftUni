namespace _02.Index_of_Letters___Exercises
{
    using System;
    using System.Linq;

    public class IndexOfLetters
    {
        public static void Main()
        {
            var letters = Console.ReadLine().ToLower().ToCharArray();
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (letters[i] == alphabet[j])
                    {
                        var index = alphabet.IndexOf(alphabet.First(x => x == letters[i]));
                        Console.WriteLine($"{letters[i]} -> {index}");
                    }
                }
            }
        }
    }
}

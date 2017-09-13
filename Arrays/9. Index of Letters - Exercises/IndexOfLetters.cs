namespace _9.Index_of_Letters___Exercises
{
    using System;

    public class IndexOfLetters
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                Console.WriteLine($"{letter} -> {letter - 'a'}");
            }
        }
    }
}

namespace _6.Strings_And_Objects___Exercises
{
    using System;

    public class StringsAndObjects
    {
        public static void Main()
        {
            string word1 = "Hello";
            string word2 = "World";
            object result = word1 + " " + word2;
            string finalResult = (string)result;

            Console.WriteLine(finalResult);
        }
    }
}

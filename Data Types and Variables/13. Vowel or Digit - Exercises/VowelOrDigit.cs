namespace _13.Vowel_or_Digit___Exercises
{
    using System;

    public class VowelOrDigit
    {
        public static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'o' || symbol == 'u' || symbol == 'e' || symbol == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

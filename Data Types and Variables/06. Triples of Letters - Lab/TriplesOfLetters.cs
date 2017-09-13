namespace _06.Triples_of_Letters___Lab
{
    using System;

    public class TriplesOfLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0; third < n; third++)
                    {
                        char letter1 = (char)('a' + first);
                        char letter2 = (char)('a' + second);
                        char letter3 = (char)('a' + third);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
                }
            }
        }
    }
}

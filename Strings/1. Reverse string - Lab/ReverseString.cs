namespace _1.Reverse_string___Lab
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var result = input.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}

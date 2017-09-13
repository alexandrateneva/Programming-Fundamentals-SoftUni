namespace _6.Reverse_Array_of_Strings___Lab
{
    using System;
    using System.Linq;

    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var words = text.Split(' ').Reverse();

            Console.WriteLine(string.Join(" ", words));
        }
    }
}

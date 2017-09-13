namespace _05.Short_Words_Sorted___lab
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(n => n)
                .ToList();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}

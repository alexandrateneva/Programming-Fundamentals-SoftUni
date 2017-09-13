namespace _04.Largest_3_Numbers___Lab
{
    using System;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse)
                            .OrderByDescending(n => n)
                            .Take(3)
                            .ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

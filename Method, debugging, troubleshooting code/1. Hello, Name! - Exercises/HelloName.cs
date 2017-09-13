namespace _1.Hello__Name____Exercises
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine(PrintName(name));

        }

        public static string PrintName(string name)
        {
            return $"Hello, {name}!";
        }
    }
}

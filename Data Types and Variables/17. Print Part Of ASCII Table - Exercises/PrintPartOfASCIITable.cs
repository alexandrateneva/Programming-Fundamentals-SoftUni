namespace _17.Print_Part_Of_ASCII_Table___Exercises
{
    using System;

    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            char firstSymbol = Convert.ToChar(start);
            char lastSymbol = Convert.ToChar(end);

            for (char i = firstSymbol; i <= lastSymbol; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

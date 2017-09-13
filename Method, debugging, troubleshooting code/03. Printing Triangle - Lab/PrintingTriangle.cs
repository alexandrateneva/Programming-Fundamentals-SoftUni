namespace _03.Printing_Triangle___Lab
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                PrintLine(1, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i < end + 1; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}

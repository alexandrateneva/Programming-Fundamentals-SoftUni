namespace _14.Number_Table
{
    using System;

    public class NumberTable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    num = row + col + 1;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }
                    if (col == 0)
                    {
                        Console.Write(num);
                    }
                    else
                    {
                        Console.Write(" " + num);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

namespace _04.Draw_a_Filled_Square___Lab
{
    using System;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintDashRow(n);
            PrintMiddleRow(n);
            PrintDashRow(n);
        }

        static void PrintDashRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintMiddleRow(int n)
        {
            for (int a = 0; a < n - 2; a++)
            {
                Console.Write("-");
                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}

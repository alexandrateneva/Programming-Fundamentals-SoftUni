namespace _13.Number_Pyramid
{
    using System;

    public class NumberPyramid
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 1; num < n + 1; row++)
            {
                for (int i = 1; i <= row; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(num);
                    }
                    else
                    {
                        Console.Write(" " + num);
                    }
                    num++;
                    if (num == n + 1)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

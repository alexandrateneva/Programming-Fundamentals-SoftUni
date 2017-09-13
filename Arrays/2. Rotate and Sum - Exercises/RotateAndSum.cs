namespace _2.Rotate_and_Sum___Exercises
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotation = int.Parse(Console.ReadLine());
            var sum = new int[array.Length];

            for (int r = 0; r < rotation; r++)
            {
                int lastElement = array[array.Length - 1];

                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastElement;

                for (int i = 0; i < array.Length; i++)
                {
                    sum[i] += array[i];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}

namespace _3.Fold_and_Sum___Exercises
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var newArr = new int[numbers.Length / 2];

            for (int i = 0; i < k; i++)
            {
                newArr[Math.Abs(i - (k - 1))] = numbers[i];
            }

            int p = k;
            for (int i = numbers.Length - 1; i >= numbers.Length - k; i--)
            {
                newArr[p] = numbers[i];
                p++;
            }

            var result = new int[numbers.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = newArr[i] + numbers[k];
                k++;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

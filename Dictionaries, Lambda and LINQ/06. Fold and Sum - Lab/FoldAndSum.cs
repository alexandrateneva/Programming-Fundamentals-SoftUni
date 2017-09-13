namespace _06.Fold_and_Sum___Lab
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int k = numbers.Count / 4;

            var firstLeftRow = numbers.Take(k).Reverse().ToList();
            var firstRightRow = numbers.Skip(numbers.Count - k).Reverse().ToList();
            var firstRow = firstLeftRow.Concat(firstRightRow).ToList();
            var secondRow = numbers.Skip(k).Take(k * 2).ToList();

            var result = firstRow.Zip(secondRow, (x, y) => x + y).ToList();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}

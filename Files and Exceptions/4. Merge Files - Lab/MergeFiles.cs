namespace _4.Merge_Files___Lab
{
    using System;
    using System.Linq;
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            var firstInput = File.ReadAllText(@"../../FileOne.txt").Split(new char[] { '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            var secondInput = File.ReadAllText(@"../../FileTwo.txt").Split(new char[] { '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = (firstInput.Concat(secondInput))
                .OrderBy(n => n)
                .Select(n => n.ToString())
                .ToArray();

            File.WriteAllLines(@"../../Output.txt", result);
        }
    }
}

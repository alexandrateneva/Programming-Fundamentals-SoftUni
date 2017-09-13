namespace _2.Line_Numbers___Lab
{
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
       public static void Main()
        {
            var input = File.ReadAllLines(@"../../input.txt");

            var result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var number = i + 1;
               result.Add($"{number.ToString()}. {input[i]}");
            }
            File.WriteAllLines(@"../../output.txt", result);
        }
    }
}

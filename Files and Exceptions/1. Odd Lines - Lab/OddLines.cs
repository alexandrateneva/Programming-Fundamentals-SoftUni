

namespace _1.Odd_Lines___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class OddLines
    {
       public static void Main()
        {
            var file = @"..\..\input.txt";

            var lines = File.ReadAllLines(file);

            var oddLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(lines[i]);
                }
            }
            File.WriteAllLines(@"..\..\output.txt", oddLines); 
        }
    }
}

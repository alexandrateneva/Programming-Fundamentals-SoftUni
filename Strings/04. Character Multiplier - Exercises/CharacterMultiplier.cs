namespace _04.Character_Multiplier___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var str1 = input[0].ToCharArray();
            var str2 = input[1].ToCharArray();

            var str1asInt = new List<int>();
            foreach (var symbol in str1)
            { str1asInt.Add((int)(symbol)); }

            var str2asInt = new List<int>();
            foreach (var symbol in str2)
            { str2asInt.Add((int)(symbol)); }

            var result = new List<int>();

            for (int i = 0; i < Math.Min(str1asInt.Count, str2asInt.Count); i++)
            {
                result.Add(str1asInt[i] * str2asInt[i]);
            }

            var diff = Math.Abs(str1asInt.Count - str2asInt.Count);
            if (diff > 0)
            {
                for (int i = 0; i < diff; i++)
                {
                    if (str1asInt.Count > str2asInt.Count)
                    {
                        result.Add(str1asInt[str2asInt.Count + i]);
                    }
                    else
                    {
                        result.Add(str2asInt[str1asInt.Count + i]);
                    }
                }
            }
            Console.WriteLine(result.Sum());
        }
    }
}

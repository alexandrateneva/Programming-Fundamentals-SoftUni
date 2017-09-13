namespace _08.Letters_Change_Numbers___Exercises
{
    using System;
    using System.Linq;

    public class LetterChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var finalResult = 0d;
            for (int i = 0; i < input.Length; i++)
            {
                var str = input[i].ToList();
                var numAsStr = str.Skip(1).Take(str.Count - 2).ToList();
                var numAsInt = int.Parse(string.Join("", numAsStr));
                var result = GetSum(str[0], numAsInt, str[str.Count - 1]);
                finalResult += result;
            }
            Console.WriteLine($"{finalResult:F2}");
        }

        public static double GetSum(char firstLetter, int number, char lastLetter)
        {
            var lowerCase = "0abcdefghijklmnopqrstuvwxyz".ToList();
            var upperCase = "0ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
            var result = 0d;
            if (lowerCase.Contains(firstLetter))
            {
                result = (double)(number) * lowerCase.IndexOf(firstLetter);
            }
            else if (upperCase.Contains(firstLetter))
            {
                result = (double)(number) / upperCase.IndexOf(firstLetter);
            }
            if (lowerCase.Contains(lastLetter))
            {
                result += lowerCase.IndexOf(lastLetter);
            }
            else if (upperCase.Contains(lastLetter))
            {

                result -= upperCase.IndexOf(lastLetter);
            }
            return result;
        }
    }
}

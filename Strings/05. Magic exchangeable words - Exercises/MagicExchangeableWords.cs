namespace _05.Magic_exchangeable_words___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var firstWord = input[0].ToList();
            var secondWord = input[1].ToList();
            var dict = new Dictionary<char, char>();

            var longerWord = new List<char>();
            var shorterWord = new List<char>();

            if (firstWord.Count >= secondWord.Count)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }
            bool result = true;
            for (int i = 0; i < shorterWord.Count; i++)
            {
                var currentLetterShortWord = shorterWord[i];
                var currentLetterLongWord = longerWord[i];

                if (!dict.ContainsValue(currentLetterShortWord) && !dict.ContainsKey(currentLetterLongWord))
                {
                    dict[currentLetterLongWord] = currentLetterShortWord;
                }
                else
                {
                    if (dict.ContainsKey(currentLetterShortWord))
                    {
                        var otherLetter = dict[currentLetterShortWord];
                        if (otherLetter != currentLetterLongWord)
                        {
                            result = false;
                            break;
                        }
                    }
                    else if (dict.ContainsValue(currentLetterShortWord))
                    {
                        var otherLetter = dict.FirstOrDefault(x => x.Value == currentLetterShortWord).Key;
                        if (otherLetter != currentLetterLongWord)
                        {
                            result = false;
                            break;
                        }
                    }
                    else if (dict.ContainsKey(currentLetterLongWord))
                    {
                        var otherLetter = dict[currentLetterLongWord];
                        if (otherLetter != currentLetterShortWord)
                        {
                            result = false;
                            break;
                        }
                    }
                    else if (dict.ContainsValue(currentLetterLongWord))
                    {
                        var otherLetter = dict.FirstOrDefault(x => x.Value == currentLetterLongWord).Key;
                        if (otherLetter != currentLetterShortWord)
                        {
                            result = false;
                            break;
                        }
                    }

                }
            }
            var diff = longerWord.Count - shorterWord.Count;
            if (diff > 0)
            {
                for (int i = 0; i < diff; i++)
                {
                    var index = shorterWord.Count - i;
                    if (!dict.ContainsKey(longerWord[index])
                        && !dict.ContainsValue(longerWord[index]))
                    {
                        result = false;
                        break;
                    }
                }
            }

            Console.WriteLine(result.ToString().ToLower());
        }
    }
}

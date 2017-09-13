namespace _2.Count_Substring_Occurrences___Lab
{
    using System;

    public class CountSubstringOccurences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();
            var counter = 1;
            var founder2 = -1;

            var founder = input.IndexOf(substring);

            if (founder >= 0)
            {
                while (true)
                {
                    founder = input.IndexOf(substring, founder + 1);
                    if (founder == -1)
                    {
                        break;
                    }
                    if (founder != founder2)
                    {
                        counter++;
                        founder2 = founder;
                    }

                }

            }
            else
            {
                counter = 0;
            }

            Console.WriteLine(counter);
        }
    }
}

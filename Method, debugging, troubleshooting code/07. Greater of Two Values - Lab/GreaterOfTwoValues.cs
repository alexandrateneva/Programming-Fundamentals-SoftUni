namespace _07.Greater_of_Two_Values___Lab
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }


        }

        static int GetMax(int first, int second)
        {
            int result = Math.Max(first, second);
            return result;
        }

        static char GetMax(char first, char second)
        {
            return (char)GetMax((int)first, (int)second);

            //if (first >= second)
            //{
            //    char result = first;
            //    return result;
            //}
            //else
            //{
            //    char result = second;
            //    return result;
            //}
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                string result = first;
                return result;
            }
            else
            {
                string result = second;
                return result;
            }
        }
    }
}

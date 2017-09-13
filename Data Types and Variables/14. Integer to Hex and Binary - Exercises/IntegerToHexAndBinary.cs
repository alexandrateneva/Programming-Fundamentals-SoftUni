namespace _14.Integer_to_Hex_and_Binary___Exercises
{
    using System;

    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 16).ToUpper());
            Console.WriteLine(Convert.ToString(number, 2));
        }
    }
}

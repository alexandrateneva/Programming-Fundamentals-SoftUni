namespace _4.Variable_in_Hex_Format___Exercises
{
    using System;

    public class VariableInHexFormat
    {
        public static void Main()
        {
            string num = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(num, 16));
        }
    }
}

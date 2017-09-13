namespace _5.Boolean_Variable___Exercises
{
    using System;

    public class BooleanVariable
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (Convert.ToBoolean(input) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

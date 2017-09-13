namespace _05.Invalid_Number
{
    using System;

    public class InvalidNumber
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            if (!(number >= 100 && 200 >= number || number == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

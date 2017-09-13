namespace _11.Enter_Even_Number
{
    using System;

    public class EnterEvenNumber
    {
        public static void Main()
        {
            var n = 0;

            while (true)
            {
                Console.Write("Enter even number: ");

                try
                {
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", n);
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }

}

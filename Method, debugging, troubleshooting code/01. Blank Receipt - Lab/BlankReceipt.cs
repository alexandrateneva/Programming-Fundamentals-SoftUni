namespace _01.Blank_Receipt___Lab
{
    using System;

    public class BlankReceipt
    {
       public static void Main()
        {
            printReceipt();
        }

        static void printReceipt ()
        {
            printHeader();
            printBody();
            printFooter();
        }

        static void printHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------"); 

        }

        static void printBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void printFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni"); 
        }
    }
}

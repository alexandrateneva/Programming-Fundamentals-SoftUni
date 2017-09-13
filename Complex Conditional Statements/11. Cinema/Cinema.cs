namespace _11.Cinema
{
    using System;

    public class Cinema
    {
        public static void Main()
        {
            string show = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            decimal price = 0.0m;

            if ( show.ToLower()== "premiere")
            {
                price = 12.00m;
            }
            else if (show.ToLower() == "normal")
            {
                price = 7.50m;
            }
            else if (show.ToLower()=="discount")
            {
                price = 5.00m;
            }
            Console.WriteLine("{0:f2}" + " leva",price*row*column);
        }
    }
}

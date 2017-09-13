namespace _02.Small_Shop
{
    using System;

    public class SmallShop
    {
        public static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());
            decimal price = 0.0m;

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    price = 0.50m;
                }
                else if (product == "water")
                {
                    price = 0.80m;
                }
                else if (product == "beer")
                {
                    price = 1.20m;
                }
                else if (product == "sweets")
                {
                    price = 1.45m;
                }
                else if (product == "peanuts")
                {
                    price = 1.60m;
                }
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40m;
                }
                else if (product == "water")
                {
                    price = 0.70m;
                }
                else if (product == "beer")
                {
                    price = 1.15m;
                }
                else if (product == "sweets")
                {
                    price = 1.30m;
                }
                else if (product == "peanuts")
                {
                    price = 1.50m;
                }
            }
            else if (town == "varna")
            {
                if (product == "coffee")
                {
                    price = 0.45m;
                }
                else if (product == "water")
                {
                    price = 0.70m;
                }
                else if (product == "beer")
                {
                    price = 1.10m;
                }
                else if (product == "sweets")
                {
                    price = 1.35m;
                }
                else if (product == "peanuts")
                {
                    price = 1.55m;
                }
            }
            Console.WriteLine(price * quantity);
        }
    }
}

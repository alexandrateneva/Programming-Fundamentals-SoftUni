namespace _07.Fruit_Shop
{
    using System;

    public class FruitShop
    {
        public static void Main()
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var quantity = decimal.Parse(Console.ReadLine());
            decimal price = 0.0m;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50m;
                }
                else if (fruit == "apple")
                {
                    price = 1.20m;
                }
                else if (fruit == "orange")
                {
                    price = 0.85m;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45m;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70m;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50m;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85m;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
                if (fruit == "banana")
                {
                    price = 2.70m;
                }
                else if (fruit == "apple")
                {
                    price = 1.25m;
                }
                else if (fruit == "orange")
                {
                    price = 0.90m;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60m;
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00m;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60m;
                }
                else if (fruit == "grapes")
                {
                    price = 4.20m;
                }
                else
                {
                    Console.WriteLine("error");
                }
            else
            {
                Console.WriteLine("error");
            }

            var totalPrice = Math.Round(price * quantity, 2);
            {
                Console.WriteLine(totalPrice);
            }
        }
    }
}

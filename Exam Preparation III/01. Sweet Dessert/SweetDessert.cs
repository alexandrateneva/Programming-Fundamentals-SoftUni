namespace _01.Sweet_Dessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {

            var moneyHeHas = decimal.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPriceKilo = decimal.Parse(Console.ReadLine());

            var portions = Math.Ceiling(numberOfGuests / 6m);
            var finalSum = (portions * 2 * bananaPrice) + (portions * 4 * eggPrice) + (portions * 0.2m * berriesPriceKilo);
            var diff = moneyHeHas - finalSum;
            if (diff >= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {finalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(diff):F2}lv more.");
            }
        }
    }
}

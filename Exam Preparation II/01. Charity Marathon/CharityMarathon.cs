
namespace _01.Charity_Marathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            var lenghtOfTime = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var lapsPerPerson = int.Parse(Console.ReadLine());
            var lapsLenght = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            if (lenghtOfTime * trackCapacity < numberOfRunners)
            {
                numberOfRunners = lenghtOfTime * trackCapacity;
            }

            ulong totalMeters = (ulong)numberOfRunners * (ulong)lapsPerPerson * (ulong)lapsLenght;
            ulong totalKilometres = totalMeters / 1000;
            double totalMoney = totalKilometres * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}

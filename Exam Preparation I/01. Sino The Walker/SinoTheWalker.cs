namespace _01.Sino_The_Walker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            DateTime timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var numberOfSteps = int.Parse(Console.ReadLine()) % 86400;
            var timeForStep = int.Parse(Console.ReadLine()) % 86400;
            long needTime = numberOfSteps * timeForStep;

            TimeSpan time = TimeSpan.FromSeconds(needTime);
            var finalTime = (timeOfLeaving + time).ToString(@"HH:mm:ss");
            Console.WriteLine($"Time Arrival: {finalTime}");
        }
    }
}

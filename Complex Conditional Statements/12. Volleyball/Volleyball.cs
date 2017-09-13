namespace _12.Volleyball
{
    using System;

    public class Volleyball
    {
        public static void Main()
        {
            string year = Console.ReadLine();
            double fest = double.Parse(Console.ReadLine());
            double weekendTravel = double.Parse(Console.ReadLine());

            double weekend = 48;
            double times = 0;
            double weekendSofia = weekend - weekendTravel;

            if (weekendTravel == 0)
            {
                times = 0.66667 * fest + 0.75 * weekendSofia;
            }
            else if (weekendTravel > 0)
            {
                times = 0.66667 * fest + 0.75 * weekendSofia + weekendTravel;
            }
            if (year.ToLower() == "leap")
            {
                times = times + (times * 0.15);
            }
            else if (year.ToLower() == "normal")
            {
                times = times * 1;
            }
            Console.WriteLine(Math.Truncate(times));
        }
    }
}

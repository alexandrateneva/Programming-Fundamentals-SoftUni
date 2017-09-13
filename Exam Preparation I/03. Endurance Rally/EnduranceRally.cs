namespace _03.Endurance_Rally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToList();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToList();
            var checkPoints = Console.ReadLine().Split().Select(double.Parse).ToList();

            foreach (var name in names)
            {
                var isFinish = true;
                var startFuel = (int)name[0];
                double finalFuel = startFuel;
                double finalZone = 0;
                for (int i = 0; i < zones.Count; i++)
                {
                    if (checkPoints.Contains(i))
                    {
                        finalFuel += zones[i]; 
                    }
                    else
                    {
                        finalFuel -= zones[i];
                    }
                    if (finalFuel <= 0)
                    {
                        isFinish = false;
                        finalZone = i;
                        break;
                    }
                }
                if (isFinish)
                {
                    Console.WriteLine($"{name} - fuel left {finalFuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{name} - reached {finalZone}");
                }
            }
        }
    }
}

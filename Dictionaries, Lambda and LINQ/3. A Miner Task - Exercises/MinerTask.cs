namespace _3.A_Miner_Task___Exercises
{
    using System;
    using System.Collections.Generic;

    public class MinerTask
    {
        public static void Main()
        {
            string resource = null;
            var resourcesAndQuantities = new Dictionary<string, int>();

            while (resource != "stop")
            {
                resource = Console.ReadLine();
                if (resource != "stop")
                {
                    if (resourcesAndQuantities.ContainsKey(resource))
                    {
                        resourcesAndQuantities[resource] = resourcesAndQuantities[resource] + int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        resourcesAndQuantities[resource] = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    foreach (var item in resourcesAndQuantities)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }

        }
    }
}

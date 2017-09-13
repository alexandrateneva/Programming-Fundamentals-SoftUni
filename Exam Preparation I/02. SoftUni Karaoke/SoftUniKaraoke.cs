namespace _02.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var particitants = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var songs = Console.ReadLine().Split(',').Select(n => n.Trim()).ToList();
            var result = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine().Split(',').Select(n => n.Trim()).ToList();
                if (input[0] == "dawn")
                {
                    break;
                }
                if (particitants.Contains(input[0]) && songs.Contains(input[1]))
                {
                    if (!result.ContainsKey(input[0]))
                    {
                        result[input[0]] = new List<string>();
                    }
                    if (!result[input[0]].Contains(input[2]))
                    {
                        result[input[0]].Add(input[2]);
                        var orderedList = result[input[0]].OrderBy(n => n).ToList();
                        result[input[0]] = orderedList;
                    }
                }
            }
            var resultDict = result.OrderByDescending(i => i.Value.Count).ThenBy(i => i.Key);
            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in resultDict)
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                    foreach (var award in item.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}

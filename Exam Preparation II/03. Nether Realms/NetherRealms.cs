using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms
{
    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse)
                .OrderBy(a => a.Name)
                .ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Demage:F2} damage");
            }
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Demage { get; set; }

        public static Demon Parse(string demonName)
        {
            var demon = new Demon();
            demon.Name = demonName;
            demon.Health = CalculateHealth(demonName);
            demon.Demage = CalculateDemage(demonName);
            return demon;
        }

        private static decimal CalculateDemage(string demonName)
        {
            var demageNumberPattern = @"[+-]?\d+(?:\.?\d+)?";
            //var demage = Regex.Matches(demonName, demageNumberPattern)
            //    .Cast<Match>()
            //    .Select(a => (decimal)char.Parse(a.Value))
            //    .Sum();
            // -> demageSum става demage, така си спестяваме foreach за всеки match
            var demageNumbers = Regex.Matches(demonName, demageNumberPattern);
            var demageSum = 0m;
            foreach (Match match in demageNumbers)
            {
                demageSum += decimal.Parse(match.Value);
            }

            var modifiers = demonName
                .Where(a => a == '*' || a == '/')
                .ToArray();

            foreach (var modifier in modifiers)
            {
                switch (modifier)
                {
                    case '*': demageSum *= 2; break;
                    case '/': demageSum /= 2; break;
                }
            }
            return demageSum;
        }

        private static decimal CalculateHealth(string demonName)
        {
            var healthPattern = @"[^0-9+\-*\/.]";
            //var health = Regex.Matches(demonName, healthRegex)
            //    .Cast<Match>()
            //    .Select(a => (decimal)char.Parse(a.Value))
            //    .Sum();
            // -> така връща директно health, така си спестяваме foreach за всеки match
            var healthChars = Regex.Matches(demonName, healthPattern);
            var healthValues = new List<decimal>();
            foreach (Match match in healthChars)
            {
                healthValues.Add((int)char.Parse(match.Value));
            }
            var health = healthValues.Sum();

            return health;
        }
    }
}
   

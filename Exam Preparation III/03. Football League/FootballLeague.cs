namespace _03.Football_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class FootballLeague
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);
            var pattern = $".*?{key}(.*?){key}.*?{key}(.*?){key}.*?(\\d+):(\\d+)";
            var regex = new Regex(pattern);
            var allTeams = new List<Team>();
            var input = Console.ReadLine();
            while (input != "final")
            {
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    var firstName = match.Groups[1].Value.ToUpper().ToCharArray();
                    var lastFirstName = firstName.Reverse().ToList();
                    var secondName = match.Groups[2].Value.ToUpper().ToCharArray();
                    var lastSecondName = secondName.Reverse().ToList();

                    var firstTeam = new Team
                    {
                        Name = string.Join("", lastFirstName),
                        Goals = int.Parse(match.Groups[3].Value)
                    };

                    var secondTeam = new Team
                    {
                        Name = string.Join("", lastSecondName),
                        Goals = int.Parse(match.Groups[4].Value)
                    };
                    bool firstIsWinner = false;
                    bool secondIsWinner = false;
                    bool draw = false;
                    if (int.Parse(match.Groups[3].Value) > int.Parse(match.Groups[4].Value))
                    {
                        firstIsWinner = true;
                        firstTeam.Points = 3;
                    }
                    else if (int.Parse(match.Groups[3].Value) < int.Parse(match.Groups[4].Value))
                    {
                        secondIsWinner = true;
                        secondTeam.Points = 3;
                    }
                    else if (true)
                    {
                        draw = true;
                        firstTeam.Points = 1;
                        secondTeam.Points = 1;
                    }
                    var firstIndex = allTeams.FindIndex(f => f.Name == string.Join("", lastFirstName));
                    var secondIndex = allTeams.FindIndex(f => f.Name == string.Join("", lastSecondName));
                    if (firstIndex < 0)
                    {
                        allTeams.Add(firstTeam);
                    }
                    else
                    {
                        allTeams[firstIndex].Goals += int.Parse(match.Groups[3].Value);
                        if (firstIsWinner)
                        {
                            allTeams[firstIndex].Points += 3;
                        }
                        else if (draw)
                        {
                            allTeams[firstIndex].Points += 1;
                        }
                    }
                    if (secondIndex < 0)
                    {
                        allTeams.Add(secondTeam);
                    }
                    else
                    {
                        allTeams[secondIndex].Goals += int.Parse(match.Groups[4].Value);
                        if (secondIsWinner)
                        {
                            allTeams[secondIndex].Points += 3;
                        }
                        else if (draw)
                        {
                            allTeams[secondIndex].Points += 1;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            var resultPoint = allTeams.OrderByDescending(a => a.Points).ThenBy(a => a.Name).ToList();
            var resultGoals = allTeams.OrderByDescending(a => a.Goals).ThenBy(a => a.Name).Take(3).ToList();
            Console.WriteLine("League standings:");
            for (int i = 0; i < resultPoint.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {resultPoint[i].Name} {resultPoint[i].Points}");
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var result in resultGoals)
            {
                Console.WriteLine($"- {result.Name} -> {result.Goals}");
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Goals { get; set; }
    }
}

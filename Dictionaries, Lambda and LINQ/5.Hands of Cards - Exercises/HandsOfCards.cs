namespace _5.Hands_of_Cards___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var pointsOfPerson = new Dictionary<string, int>();
            var cardsOfPerson = new Dictionary<string, List<string>>();
            var oldList = new List<string>();

            while (true)
            {
                var input = Console.ReadLine()
                        .Split(new char[] { ':', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Distinct()
                        .ToList();
                if (input[0] == "JOKER")
                {
                    foreach (var item in cardsOfPerson)
                    {
                        var sum = 0;
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            var card = item.Value[i].ToString().ToArray();
                            var power = 0;
                            var multipliar = 0;
                            char kindOfCard = '\0';
                            if (card.Length == 3)
                            {
                                power = 10;
                                kindOfCard = card[2];
                            }
                            else
                            {
                                switch (card[0])
                                {
                                    case '1': power = 1; break;
                                    case '2': power = 2; break;
                                    case '3': power = 3; break;
                                    case '4': power = 4; break;
                                    case '5': power = 5; break;
                                    case '6': power = 6; break;
                                    case '7': power = 7; break;
                                    case '8': power = 8; break;
                                    case '9': power = 9; break;
                                    case 'J': power = 11; break;
                                    case 'Q': power = 12; break;
                                    case 'K': power = 13; break;
                                    case 'A': power = 14; break;
                                    default: break;
                                }
                                kindOfCard = card[1];
                            }
                            switch (kindOfCard)
                            {
                                case 'S': multipliar = 4; break;
                                case 'H': multipliar = 3; break;
                                case 'D': multipliar = 2; break;
                                case 'C': multipliar = 1; break;
                                default: break;
                            }
                            sum += multipliar * power;
                        }
                        pointsOfPerson[item.Key] = sum;
                    }
                    foreach (var item in pointsOfPerson)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }
                else
                {
                    var newList = input.Skip(1).Distinct().ToList();

                    if (cardsOfPerson.ContainsKey(input[0]))
                    {
                        var lastList = newList.Concat(cardsOfPerson[input[0]]).Distinct().ToList();
                        cardsOfPerson[input[0]] = lastList;
                        oldList = lastList;
                    }
                    else
                    {
                        pointsOfPerson[input[0]] = 0;
                        cardsOfPerson[input[0]] = newList;
                        oldList = newList;
                    }
                }
            }
        }
    }
}

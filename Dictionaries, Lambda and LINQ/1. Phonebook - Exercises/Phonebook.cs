namespace _1.Phonebook___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            string command = null;
            var result = new List<string>();
            var phoneBook = new Dictionary<string, string>();

            while (command != "END")
            {
                var listOfCommand = Console.ReadLine().Split(' ').ToList();
                command = listOfCommand[0];

                if (command == "A")
                {
                    phoneBook[listOfCommand[1]] = listOfCommand[2];
                }
                else if (command == "S")
                {
                    if (phoneBook.ContainsKey(listOfCommand[1]))
                    {
                        result.Add($"{listOfCommand[1]} -> {phoneBook[listOfCommand[1]]}");
                    }
                    else
                    {
                        result.Add($"Contact {listOfCommand[1]} does not exist.");
                    }
                }
                else if (command == "END")
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        Console.WriteLine(result[i]);
                    }
                }
            }
        }
    }
}
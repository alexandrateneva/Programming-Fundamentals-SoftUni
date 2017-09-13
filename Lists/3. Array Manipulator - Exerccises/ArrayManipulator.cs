namespace _3.Array_Manipulator___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var listOfCommand = new List<string>();
            var listOfResults = new List<int>();
            string command = null;

            while (command != "print")
            {
                command = Console.ReadLine();
                listOfCommand = command.Split(' ').ToList();
                if (listOfCommand[0] == "add")
                {
                    var index = int.Parse(listOfCommand[1]);
                    var element = int.Parse(listOfCommand[2]);
                    numbers.Insert(index, element);
                }
                else if (listOfCommand[0] == "addMany")
                {
                    var index = int.Parse(listOfCommand[1]);
                    var elements = listOfCommand.Skip(2).Select(int.Parse).ToList();
                    for (int i = elements.Count - 1; i >= 0; i--)
                    {
                        numbers.Insert(index, elements[i]);
                    }
                }
                else if (listOfCommand[0] == "contains")
                {
                    var index = 0;
                    var element = int.Parse(listOfCommand[1]);
                    if (numbers.Contains(element))
                    {
                        index = numbers.IndexOf(numbers.First(x => x == element));
                        listOfResults.Add(index);
                    }
                    else
                    {
                        index = -1;
                        listOfResults.Add(index);
                    }
                }
                else if (listOfCommand[0] == "remove")
                {
                    var index = int.Parse(listOfCommand[1]);
                    numbers.RemoveAt(index);
                }
                else if (listOfCommand[0] == "shift")
                {
                    var position = int.Parse(listOfCommand[1]);
                    for (int i = 0; i < position; i++)
                    {
                        int first = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(first);
                    }
                }
                else if (listOfCommand[0] == "sumPairs")
                {
                    int n = numbers.Count;
                    for (int i = 0; i < n / 2; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }
            }
            if (command == "print")
            {
                for (int i = 0; i < listOfResults.Count; i++)
                {
                    Console.WriteLine(listOfResults[i]);
                }
                Console.Write("[");
                Console.Write(string.Join(", ", numbers));
                Console.WriteLine("]");
            }
        }
    }
}

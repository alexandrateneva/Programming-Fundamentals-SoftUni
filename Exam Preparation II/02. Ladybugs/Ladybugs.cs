

namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
       public static void Main()
        {

            var fieldSize = int.Parse(Console.ReadLine());

            var ladybugIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(a => a >= 0 && a < fieldSize)
                .ToArray();

            var ladyBugs = new int[fieldSize];

            for (int i = 0; i < ladybugIndexes.Length; i++)
            {
                var currentLadybugIndex = ladybugIndexes[i];
                ladyBugs[currentLadybugIndex] = 1;
            }
            var line = Console.ReadLine();
            while (line != "end")
            {
                var tokens = line.Split();
                var ladybugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= ladyBugs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (ladyBugs[ladybugIndex] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }
                MoveLadybug(ladyBugs, ladybugIndex, flyLength, direction);
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugs));    
        }

        static void MoveLadybug(int [] ladybugs, int ladybugIndex, int flyLenght, string direction)
        {
            ladybugs[ladybugIndex] = 0;
            var leftArrayOrFoundPlace = false;
            while (!leftArrayOrFoundPlace)
            {
                switch (direction)
                {
                    case "left": ladybugIndex -= flyLenght; break;
                    case "right": ladybugIndex += flyLenght; break;
                }
                if (ladybugIndex < 0 || ladybugIndex >= ladybugs.Length)
                {
                    leftArrayOrFoundPlace = true;
                    continue;
                }
                if (ladybugs[ladybugIndex] == 1)
                {
                    continue;
                }

                if (ladybugs[ladybugIndex] == 0)
                {
                    ladybugs[ladybugIndex] = 1;
                    leftArrayOrFoundPlace = true;
                    continue;
                }
            }
        }    


    }
}

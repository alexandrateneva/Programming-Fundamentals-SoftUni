namespace _5.Bomb_Numbers___Exercises
{
    using System;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var specialNumAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int specialNumber = specialNumAndPower[0];
            int power = specialNumAndPower[1];
            var sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    if (i - power < 0)
                    {
                        numbers.RemoveRange(0, i + power + 1);
                    }
                    else if (i + power > numbers.Count - 1)
                    {
                        numbers.RemoveRange(i - power, numbers.Count - (i - power));
                    }
                    else
                    {
                        numbers.RemoveRange(i - power, (2 * power) + 1);
                    }
                    i = -1;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

        }
    }
}

namespace _04.Tripple_Sum___Lab
{
    using System;
    using System.Linq;

    public class TrippleSum
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var arr = input.Split(' ').Select(int.Parse).ToArray();
            bool ContainSum = false;

            for (int a = 0; a < arr.Length; a++)
            {
                var sum = 0;
                for (int b = a + 1; b < arr.Length; b++)
                {
                    sum = arr[a] + arr[b];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == sum)
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {sum}");
                            ContainSum = true;
                            break;
                        }
                    }
                }
            }
            if (!ContainSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}

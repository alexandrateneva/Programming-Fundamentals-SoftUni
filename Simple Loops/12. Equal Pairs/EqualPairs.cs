namespace _12.Equal_Pairs
{
    using System;

    public class EqualPairs
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int diff = 0;
            int maxDiff = 0;

            int pair1 = int.Parse(Console.ReadLine());
            int pair2 = int.Parse(Console.ReadLine());
            int sum1 = pair1 + pair2;

            for (int i = 0; i < n - 1; i++)
            {
                int pair3 = int.Parse(Console.ReadLine());
                int pair4 = int.Parse(Console.ReadLine());
                sum = pair3 + pair4;
                diff = sum - sum1;
                sum1 = sum;
                if (Math.Abs(diff) > Math.Abs(maxDiff))
                {
                    maxDiff = diff;
                }
            }
            if (diff == 0)
            {
                if (sum == 0)
                {
                    Console.WriteLine("Yes, value=" + sum1);
                }
                else
                {
                    Console.WriteLine("Yes, value=" + sum);
                }
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + Math.Abs(maxDiff));
            }
        }
    }
}

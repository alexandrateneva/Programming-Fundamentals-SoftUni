namespace _08.Odd_Even_Sum
{
    using System;

    public class OddEvenSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var EvenSum = 0;
            var OddSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    OddSum += num;
                }
                else
                {
                    EvenSum += num;
                }
            }
            if (OddSum == EvenSum)
            {
                Console.WriteLine("Yes Sum = " + OddSum);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(OddSum - EvenSum));
            }
        }
    }
}

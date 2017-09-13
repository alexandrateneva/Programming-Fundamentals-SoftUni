namespace _07.Left_and_Right_Sum
{
    using System;

    public class LeftAndRightSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var LeftSum = 0;
            var RightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                LeftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                RightSum += num;
            }
            if (LeftSum == RightSum)
            {
                Console.WriteLine("Yes, sum = " + LeftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + (Math.Abs(LeftSum - RightSum)));
            }
        }
    }
}

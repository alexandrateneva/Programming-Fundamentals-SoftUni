namespace _10.Half_Sum_Element
{
    using System;

    public class HalfSumElement
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var max = 0;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }
            if ((sum - max) == max)
            {
                Console.WriteLine("Yes sum = " + max);
            }
            else
            {
                Console.WriteLine("No diff = " + Math.Abs(max - (sum - max)));
            }
        }
    }
}

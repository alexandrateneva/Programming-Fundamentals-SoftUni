namespace _11.Odd_or_Even_Position
{
    using System;

    public class OddOrEvenPosition
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;
            double oddSum = 0.0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;
            double evenSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    double num = double.Parse(Console.ReadLine());
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
                else
                {
                    double num = double.Parse(Console.ReadLine());
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
            }
            Console.WriteLine("OddSum=" + oddSum);
            if (oddMin == 1000000000.0)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin);
            }
            if (oddMax == -1000000000.0)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax);
            }
            Console.WriteLine("EvenSum=" + evenSum);
            if (evenMin == 1000000000.0)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin);
            }
            if (evenMax == -1000000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }
        }
    }
}

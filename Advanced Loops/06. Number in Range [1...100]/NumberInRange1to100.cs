namespace _06.Number_in_Range__1._._._100_
{
	using System;

    public class NumberInRange1to100
    {
        public static void Main()
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num >100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}",num);
        }
    }
}

namespace _01.Day_of_Week___Lab
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int numberOfDay = int.Parse(Console.ReadLine());

            if (numberOfDay >= 1 && numberOfDay <= 7)
            {
                Console.WriteLine(days[numberOfDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}

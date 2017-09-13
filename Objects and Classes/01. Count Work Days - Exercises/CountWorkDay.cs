namespace _01.Count_Work_Days___Exercises
{
    using System;
    using System.Globalization;

    public class CountWorkDay
    {
        public static void Main()
        {
            var startDateAsString = Console.ReadLine();
            var endDateAsString = Console.ReadLine();

            var startDate = DateTime.ParseExact(startDateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(endDateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var counter = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var year = date.Year;
                var officialHolidays = new DateTime[11];
                officialHolidays[0] = new DateTime(year, 1, 1);
                officialHolidays[1] = new DateTime(year, 3, 3);
                officialHolidays[2] = new DateTime(year, 5, 1);
                officialHolidays[3] = new DateTime(year, 5, 6);
                officialHolidays[4] = new DateTime(year, 5, 24);
                officialHolidays[5] = new DateTime(year, 9, 6);
                officialHolidays[6] = new DateTime(year, 9, 22);
                officialHolidays[7] = new DateTime(year, 11, 1);
                officialHolidays[8] = new DateTime(year, 12, 24);
                officialHolidays[9] = new DateTime(year, 12, 25);
                officialHolidays[10] = new DateTime(year, 12, 26);

                counter++;

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    counter--;
                }
                else if (true)
                {
                    for (int i = 0; i < officialHolidays.Length; i++)
                    {
                        if (date == officialHolidays[i])
                        {
                            counter--;
                        }
                    }
                }     
            }
            Console.WriteLine(counter);
        }
    }
}

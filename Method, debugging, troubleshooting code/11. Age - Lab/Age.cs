namespace _11.Age___Lab
{
    using System;

    public class Age
    {
        public static void Main()
        {
            var age = GetAge(new DateTime(1993, 11, 14));
            Console.WriteLine(age);
        }

        public static int GetAge(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            TimeSpan result = now - dateOfBirth;
            return (int)(result.Days / 365.2422);
        }
    }
}

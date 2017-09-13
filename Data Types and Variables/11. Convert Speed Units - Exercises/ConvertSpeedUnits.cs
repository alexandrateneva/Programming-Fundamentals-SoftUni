namespace _11.Convert_Speed_Units___Exercises
{
    using System;

    public class ConvertSpeedUnits
    {
        public static void Main()
        {
            int distanceMetres = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeHours = hours + minutes / 60.0f + seconds / 3600.0f;
            float timeSeconds = hours * 3600.0f + minutes * 60.0f + seconds;

            float distanceKm = distanceMetres / 1000.0f;
            float distanceMiles = distanceMetres / 1609.0f;

            Console.WriteLine(distanceMetres / timeSeconds);
            Console.WriteLine(distanceKm / timeHours);
            Console.WriteLine(distanceMiles / timeHours);

        }
    }
}

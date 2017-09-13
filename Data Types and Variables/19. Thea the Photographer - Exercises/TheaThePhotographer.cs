namespace _19.Thea_the_Photographer___Exercises
{
    using System;

    public class TheaThePhotographer
    {
        public static void Main()
        {
            int amount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int goodPhotos = int.Parse(Console.ReadLine());
            int timeToUpload = int.Parse(Console.ReadLine());

            double percentage = goodPhotos / 100.0;
            int uploadPhotos = (int)Math.Ceiling(percentage * amount);

            long totalFilterTime = amount * (long)filterTime;
            long totalUploadTime = uploadPhotos * (long)timeToUpload;
            long totalTime = totalFilterTime + totalUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);

            Console.WriteLine(TimeSpan.FromSeconds(totalTime).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));

        }
    }
}

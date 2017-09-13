namespace _09.Melrah_Shake___Exercises
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var firstIndex = text.IndexOf(pattern);
                if (firstIndex > 0)
                {
                    text = text.Remove(firstIndex, pattern.Length);
                }
                var secondIndex = text.LastIndexOf(pattern);
                if (secondIndex > 0)
                {
                    text = text.Remove(secondIndex, pattern.Length);
                }
                if (firstIndex > 0 || secondIndex > 0)
                {
                    pattern = pattern.Remove((pattern.Length / 2), 1);
                }
                if (firstIndex > 0 && secondIndex > 0)
                {
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                }
                if ((firstIndex < 0 && secondIndex < 0) || pattern.Length == 0)
                {
                    Console.WriteLine(text);
                    break;
                }
            }
        }
    }
}

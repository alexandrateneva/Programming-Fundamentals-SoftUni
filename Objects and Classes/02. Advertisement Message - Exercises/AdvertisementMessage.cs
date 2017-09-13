﻿namespace _02.Advertisement_Message___Exercises
{
    using System;
    using System.Collections.Generic;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            var phrases = new List<string>{"Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product." };

            var events = new List<string>{"Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            var author = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            var cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            var randomIndexPhrases = new Random();

            var randomIndexEvents = new Random();
            var randomIndexAuthor = new Random();
            var randomIndexCities = new Random();

            for (int i = 0; i < n; i++)
            {
                var indexPhrases = randomIndexPhrases.Next(0, phrases.Count);
                var indexEvents = randomIndexEvents.Next(0, events.Count);
                var indexAuthors = randomIndexAuthor.Next(0, author.Count);
                var indexCities = randomIndexCities.Next(0, cities.Count);
                Console.WriteLine($"{phrases[indexPhrases]} {events[indexEvents]} {author[indexAuthors]} – {cities[indexCities]}.");
            }
        }
    }
}

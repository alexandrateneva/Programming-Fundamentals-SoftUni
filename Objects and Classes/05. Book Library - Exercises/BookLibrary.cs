namespace _05.Book_Library___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentCase = Console.ReadLine().Split(' ').ToList();
                var book = new Book();
                book.Title = currentCase[0];
                book.Author = currentCase[1];
                book.Publisher = currentCase[2];
                book.ReleaseDate = DateTime.ParseExact(currentCase[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBNnumber = int.Parse(currentCase[4]);
                book.Price = decimal.Parse(currentCase[5]);

                if (result.ContainsKey(book.Author))
                {
                    result[book.Author] += book.Price;
                }
                else
                {
                    result[book.Author] = book.Price;
                }
            }
            var print = result.OrderByDescending(r => r.Value).ThenBy(r => r.Key).ToDictionary(i => i.Key, i => i.Value);
            foreach (var item in print)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}

namespace _06.Book_Library_Modification___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var library = new List<Book>();

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
                library.Add(book);
            }
            var finalDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var print = library.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title);

            foreach (var item in print)
            {
                if (item.ReleaseDate > finalDate)
                {
                    Console.WriteLine($"{item.Title} -> {(item.ReleaseDate).ToString("dd.MM.yyyy")}");
                }
            }
        }
    }
}

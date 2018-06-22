using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> allBooks = new List<Book>();
            while (n-- != 0)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Book book = new Book(input[0], input[1], input[2], DateTime.ParseExact(input[3],
                    "dd.MM.yyyy", CultureInfo.InvariantCulture), input[4], double.Parse(input[5]));
                allBooks.Add(book);
            }
            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(),
                    "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library library = new Library("Big", allBooks);

            foreach (var item in library.BookList.Where(x => x.ReleaseDate > givenDate).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                Console.WriteLine($"{item.Title} -> {item.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public double Price { get; set; }

        public Book(string title, string autor, string Pub, DateTime dt, string isbn, double price)
        {
            Title = title;
            Autor = autor;
            Publisher = Publisher;
            ReleaseDate = dt;
            Isbn = Isbn;
            Price = price;
        }

    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> BookList { get; set; }

        public Library(string name, List<Book> list)
        {
            Name = name;
            BookList = list;
        }
    }
}

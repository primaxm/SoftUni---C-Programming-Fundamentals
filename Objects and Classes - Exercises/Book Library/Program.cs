using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Book_Library
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
            Library library = new Library("Big", allBooks);


            foreach (var item in allBooks.GroupBy(x => x.Autor).OrderByDescending(x => x.Sum(y => y.Price))
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Sum(x => x.Price):f2}");
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

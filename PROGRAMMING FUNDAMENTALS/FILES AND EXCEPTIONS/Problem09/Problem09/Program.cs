using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem09
{
    class Program
    {
        class Book
        {
            public string title { get; set; }
            public string author { get; set; }
            public string publisher { get; set; }
            public DateTime releaseDate { get; set; }
            public string ISBN { get; set; }
            public double price { get; set; }
        }
        class Library
        {
            public string name { get; set; }
            public List<Book> books { get; set; }
            public double AuthorTotalPrice(string wantedAuthor)
            {
                return books.Where(x => x.author == wantedAuthor).Select(x => x.price).Sum();
            }
            public List<string> GetAllAuthors()
            {
                List<string> allAuthors = new List<string>();
                foreach(Book book in books)
                {
                    if (!allAuthors.Contains(book.author))
                    {
                        allAuthors.Add(book.author);
                    }
                }
                return allAuthors;
            }
        }
        static DateTime GetDateTime(string s)
        {
            return new DateTime(int.Parse(s.Split('.')[2]), int.Parse(s.Split('.')[1]), int.Parse(s.Split('.')[0]));
        }
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("input.txt").Skip(1).ToArray();
            List<string> outputLines = new List<string>();
            Book currBook;
            Library myLibrary = new Library() {name = "MyLibrary", books = new List<Book>()};

            foreach (string line in inputLines)
            {
                currBook = new Book();
                currBook.title = line.Split()[0];
                currBook.author = line.Split()[1];
                currBook.publisher = line.Split()[2];
                currBook.releaseDate = GetDateTime(line.Split()[3]);
                currBook.ISBN = line.Split()[4];
                currBook.price = double.Parse(line.Split()[5]);
                myLibrary.books.Add(currBook);
            }

            foreach(string author in myLibrary.GetAllAuthors().OrderByDescending(x => myLibrary.AuthorTotalPrice(x)).ThenBy(x => x))
            {
                outputLines.Add(String.Format("{0} -> {1:F2}", author, myLibrary.AuthorTotalPrice(author)));
            }
            File.WriteAllLines("output.txt", outputLines);
        }
    }
}

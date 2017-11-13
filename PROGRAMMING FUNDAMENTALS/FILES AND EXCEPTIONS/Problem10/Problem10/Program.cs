using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem10
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
            Library myLibrary = new Library() { name = "MyLibrary", books = new List<Book>() };
            DateTime givenDate = GetDateTime(inputLines.Last());

            foreach (string line in inputLines.Take(inputLines.Length-1))
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

            foreach (Book book in myLibrary.books.Where(x => x.releaseDate > givenDate).OrderBy(x => x.releaseDate).ThenBy(x => x.title))
            {
                outputLines.Add(String.Format("{0} -> {1}", book.title, book.releaseDate.ToString("dd.MM.yyyy")));
            }
            File.WriteAllLines("output.txt", outputLines);
        }
    }
}

using HackerWe.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace HackerWe.Logic
{
    public static class Library
    {
        #region Properties
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<Client> Clients { get; set; } = new List<Client>();
        public static List<Borowing> Borowings { get; set; } = new List<Borowing>();

        #endregion

        #region Ctor's

        static Library()
        {

        }

        #endregion

        public static List<Book> RelevantBooks => Books.Where(x => x.NumberOfBorrowedOut < x.NumberOfCopies).ToList();
       
        public static List<Book> BooksByAuthor(string author)
        {
            List<Book> books = Books.Where(x => x.Author == author).ToList();
            return books;
        }

        public static List<Borowing> OverdueBorrowings(int months)
        {
            List<Borowing> OverdueBorrowings = Borowings.Where(borrow => borrow.BorowingDate.AddMonths(months) <= DateTime.Now).ToList();
            return OverdueBorrowings;
        }
        public static List<string> GetAuthorsList()
        {
            List<string> authors = new List<string>();
            foreach (var item in Books)
            {
                if(!authors.Contains(item.Author))
                    authors.Add(item.Author);
            }
            return authors;
        }
        #region File Managament
        #region Save Methods
        public static void SaveBooks()
        {
            var s = "";
            foreach (var book in Library.Books)
            {
                s += book.ToCSV() + Environment.NewLine;

            }
            File.WriteAllText(@"D:\Documents\b.csv", s);
        }

        public static void SaveBooksAsJSON()
        {
            var jsonSTR = JsonSerializer.Serialize(Library.Books);

            File.WriteAllText(@"books.json", jsonSTR);
        }
        public static void SaveBorrowings()
        {
            var jsonSTR = JsonSerializer.Serialize(Library.Borowings);
            File.WriteAllText(@"borrowings.json", jsonSTR);
        }
        public static void SaveClients()
        {
            var jsonSTR = JsonSerializer.Serialize(Library.Clients);
            File.WriteAllText(@"clients.json", jsonSTR);
        }
        #endregion

        public static void ReadBooksFromJSON()
        {
            var jsonSTR = File.ReadAllText(@"books.json");
            Library.Books = JsonSerializer.Deserialize<List<Book>>(jsonSTR);
        }

        public static void ReadClientsFromJSON()
        {
            var jsonSTR = File.ReadAllText(@"clients.json");
            Library.Clients = JsonSerializer.Deserialize<List<Client>>(jsonSTR);
        }
        public static void ReadBorrowingsFromJSON()
        {
            var jsonSTR = File.ReadAllText(@"borrowings.json");
            Library.Borowings = JsonSerializer.Deserialize<List<Borowing>>(jsonSTR);
        }
        #endregion


    }
}

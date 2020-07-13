using Microsoft.EntityFrameworkCore;
using SampleCodeFirst.Data;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace SampleCodeFirst.Models
{
    class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public bool insertBooks(BookStoreContext db = null)
        {
            Author author = db.Authors.AsNoTracking().First(x => x.Name == "Dan Brown");

            List<Book> books = new List<Book>()
            {
                new Book{ Name = "Origem", AuthorId = author.AuthorId },
                new Book{ Name = "O Código Da Vinci", AuthorId = author.AuthorId },
                new Book{ Name = "O símbolo perdido", AuthorId = author.AuthorId }
            };

            if (db == null)
                db = new BookStoreContext();

            db.AddRange(books);
            int reg = db.SaveChanges();
            if (reg > 0)
                return true;
            return false;
        }


        public ExpandoObject getBooks()
        {
            List<Book> books = new List<Book>
            {
                new Book{ Name = "Origem", AuthorId = 1 },
                new Book{ Name = "O Código Da Vinci", AuthorId = 1 },
                new Book{ Name = "O símbolo perdido", AuthorId = 1 },
                new Book{ Name = "A dança dos dragões", AuthorId = 2 },
                new Book{ Name = "O festim dos corvos", AuthorId = 2 },
                new Book{ Name = "A tormenta de espadas", AuthorId = 2 },
            };

            dynamic retorno = new ExpandoObject();
            retorno.books = books;

            return retorno;
        }

    }
}

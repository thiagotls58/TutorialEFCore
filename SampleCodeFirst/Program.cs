using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SampleCodeFirst.Data;
using SampleCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SampleCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new BookStoreContext())
            //{
            //    using (var transaction = db.Database.BeginTransaction())
            //    {
            //        bool insertAuthors = new Author().insertAuthors(db);
            //        bool insertBooks = new Book().insertBooks(db);
            //        if (insertAuthors && insertBooks)
            //            transaction.Commit();
            //    }
            //}

            var books = new Book().getBooks().Cast<Book>();
            


            Console.ReadLine();
        }
    }
}

using SampleCodeFirst.Data;
using System.Collections.Generic;
using System.Dynamic;

namespace SampleCodeFirst.Models
{
    class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; } = new List<Book>();

        public bool insertAuthors(BookStoreContext db = null)
        {
            Author author = new Author
            {
                Name = "Dan Brown"
            };

            if (db == null)
                db = new BookStoreContext();

            db.Add(author);
            int reg = db.SaveChanges();
            //if (reg > 0)
            //    return true;
            return false;
        }
                
    }
}

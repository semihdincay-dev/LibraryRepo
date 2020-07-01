using Library.BLL.Core;
using Library.DAL;
using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL
{
    public class BookRepository : IRepository<Book>
    {
        LibraryEntities db = new LibraryEntities();
        public void Add(Book entity)
        {
            db.Books.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Book entity)
        {
            db.Books.Remove(entity);
            db.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public Book GetById(int Id)
        {
            return db.Books.FirstOrDefault(z => z.Id == Id);
        }

        public void Update(Book entity)
        {
            Book updateBook = db.Books.FirstOrDefault(z => z.Id == entity.Id);
            updateBook.Name = entity.Name;
            updateBook.Author = entity.Author;
            db.SaveChanges();
        }
    }
}

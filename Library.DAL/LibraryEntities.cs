using Library.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL
{
    public class LibraryEntities : DbContext
    {
        public LibraryEntities() : base("LibraryConnection")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}

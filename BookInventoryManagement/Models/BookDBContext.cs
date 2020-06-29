using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookInventoryManagement.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext()
        {

        }


        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }


        public DbSet<Book> Books { get; set; }
       

    }
}

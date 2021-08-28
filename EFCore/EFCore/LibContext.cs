using EFCore.Models;
using EFCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore
{
    public class LibContext : DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<BooksShelf> booksShelves { get; set; }
        public DbSet<Shelf> shelves { get; set; }
        public DbSet<User> users { get; set; }


        public LibContext(DbContextOptions<LibContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new BookMapping());
            modelBuilder.ApplyConfiguration(new BookMapping());
            modelBuilder.ApplyConfiguration(new ShelfMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}

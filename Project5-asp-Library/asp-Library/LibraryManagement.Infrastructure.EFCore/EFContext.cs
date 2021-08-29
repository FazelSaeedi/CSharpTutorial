using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Domain.BookAgg;
using LibraryManagement.Domain.ShelfAgg;
using LibraryManagement.Domain.BookshelfAgg;
using LibraryManagement.Domain.UserAgg;
using LibraryManagement.Infrastructure.EFCore.Mapping;

namespace LibraryManagement.Infrastructure.EFCore
{
    public class EFContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<BookShelf> BookShelves { get; set; }
        public DbSet<User> Users { get; set; }

        public EFContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var assembly = typeof(BookMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}

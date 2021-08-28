using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Mapping
{
    public class BookShelvesMapping : IEntityTypeConfiguration<BooksShelf>
    {
        public void Configure(EntityTypeBuilder<BooksShelf> builder)
        {

            builder.ToTable("booksShelves");
            builder.HasKey(x => x.id);


            builder.HasOne(x => x.book).WithMany(x => x.booksShelves).HasForeignKey(x => x.bookId);
            builder.HasOne(x => x.shelf).WithMany(x => x.booksShelves).HasForeignKey(x => x.shelfId);
            
        }
    }
}

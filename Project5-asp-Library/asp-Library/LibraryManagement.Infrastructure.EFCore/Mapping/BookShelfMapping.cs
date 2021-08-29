using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LibraryManagement.Domain.BookshelfAgg;


namespace LibraryManagement.Infrastructure.EFCore.Mapping
{
    public class BookShelfMapping
    {
        public void Configure(EntityTypeBuilder<BookShelf> builder)
        {


            builder.ToTable("booksShelves");
            builder.HasKey(x => x.id);



            builder.Property(x => x.isReaded)
                .IsRequired();



            builder.HasOne(x => x.book).WithMany(x => x.booksShelves).HasForeignKey(x => x.bookId);
            builder.HasOne(x => x.shelf).WithMany(x => x.booksShelves).HasForeignKey(x => x.shelfId);

        }
    }
}

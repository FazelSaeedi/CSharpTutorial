using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LibraryManagement.Domain.BookAgg;

namespace LibraryManagement.Infrastructure.EFCore.Mapping
{
    public class BookMapping : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {


            builder.ToTable("books");
            builder.HasKey(x => x.id);



            builder.HasIndex(x => x.title)
                .IsUnique();
            builder.Property(x => x.title)
                .IsRequired()
                .HasMaxLength(30);



            builder.HasIndex(x => x.isbn)
                .IsUnique();
            builder.Property(x => x.isbn)
                .IsRequired()
                .HasMaxLength(13);



            builder.Property(x => x.isVisible)
                .IsRequired();



            builder.Property(x => x.pageCount)
                .IsRequired();



            builder.HasMany(x => x.booksShelves).WithOne(x => x.book).HasForeignKey(x => x.bookId);


        }
    }
}

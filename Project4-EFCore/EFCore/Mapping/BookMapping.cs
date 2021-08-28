using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Mapping
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.ToTable("books");
            builder.HasKey(x => x.id);

            builder.Property(x => x.isbn)
                .IsRequired()
                .HasMaxLength(255);


            builder.HasMany(x => x.booksShelves).WithOne(x => x.book).HasForeignKey(x => x.bookId);
            // builder.Property(x => x.isVisible).HasColumnName("isvisible");


        }
    }
}

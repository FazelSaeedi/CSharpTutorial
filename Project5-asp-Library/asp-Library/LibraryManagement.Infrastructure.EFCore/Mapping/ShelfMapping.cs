using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LibraryManagement.Domain.ShelfAgg;

namespace LibraryManagement.Infrastructure.EFCore.Mapping
{
    public class ShelfMapping : IEntityTypeConfiguration<Shelf>
    {
        public void Configure(EntityTypeBuilder<Shelf> builder)
        {


            builder.ToTable("shelves");
            builder.HasKey(x => x.id);



            builder.Property(x => x.title)
                .IsRequired()
                .HasMaxLength(30);



            builder.HasOne(x => x.user).WithMany(x => x.shelves).HasForeignKey(x => x.userId);
            builder.HasMany(x => x.booksShelves).WithOne(x => x.shelf).HasForeignKey(x => x.shelfId);

        }
    }
}

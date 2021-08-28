using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Mapping
{
    public class ShelfMapping : IEntityTypeConfiguration<Shelf>
    {
        public void Configure(EntityTypeBuilder<Shelf> builder)
        {
            builder.ToTable("shelves");
            builder.HasKey(x => x.id);


            builder.HasOne(x => x.user).WithMany(x => x.shelves).HasForeignKey(x => x.userId);
            builder.HasMany(x => x.booksShelves).WithOne(x => x.shelf).HasForeignKey(x => x.shelfId);
        }
    }
}

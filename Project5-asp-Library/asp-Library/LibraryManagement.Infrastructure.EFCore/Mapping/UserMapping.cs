using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LibraryManagement.Domain.UserAgg;

namespace LibraryManagement.Infrastructure.EFCore.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("users");
            builder.HasKey(x => x.id);



            builder.HasIndex(x => x.userName)
                .IsUnique();
            builder.Property(x => x.userName)
                .IsRequired()
                .HasMaxLength(30);



            builder.Property(x => x.password)
                .IsRequired()
                .HasMaxLength(128);


            builder.Property(x => x.phone)
                    .IsRequired()
                    .HasMaxLength(10);



            builder.Property(x => x.isActive)
                .IsRequired();
                



           builder.HasMany(x => x.shelves).WithOne(x => x.user).HasForeignKey(x => x.userId);

        }
    }
}

﻿// <auto-generated />
using System;
using LibraryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryManagement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20210828102509_initiallmigration")]
    partial class initiallmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryManagement.Domain.BookAgg.Book", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isVisible")
                        .HasColumnType("bit");

                    b.Property<long>("isbn")
                        .HasMaxLength(13)
                        .HasColumnType("bigint");

                    b.Property<int>("pageCount")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.HasIndex("isbn")
                        .IsUnique();

                    b.HasIndex("title")
                        .IsUnique();

                    b.ToTable("books");
                });

            modelBuilder.Entity("LibraryManagement.Domain.BookshelfAgg.BookShelf", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateionDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("bookId")
                        .HasColumnType("bigint");

                    b.Property<bool>("isReaded")
                        .HasColumnType("bit");

                    b.Property<long>("shelfId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("bookId");

                    b.HasIndex("shelfId");

                    b.ToTable("BookShelves");
                });

            modelBuilder.Entity("LibraryManagement.Domain.ShelfAgg.Shelf", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("shelves");
                });

            modelBuilder.Entity("LibraryManagement.Domain.UserAgg.User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.HasIndex("userName")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("LibraryManagement.Domain.BookshelfAgg.BookShelf", b =>
                {
                    b.HasOne("LibraryManagement.Domain.BookAgg.Book", "book")
                        .WithMany("booksShelves")
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagement.Domain.ShelfAgg.Shelf", "shelf")
                        .WithMany("booksShelves")
                        .HasForeignKey("shelfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("shelf");
                });

            modelBuilder.Entity("LibraryManagement.Domain.ShelfAgg.Shelf", b =>
                {
                    b.HasOne("LibraryManagement.Domain.UserAgg.User", "user")
                        .WithMany("shelves")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("LibraryManagement.Domain.BookAgg.Book", b =>
                {
                    b.Navigation("booksShelves");
                });

            modelBuilder.Entity("LibraryManagement.Domain.ShelfAgg.Shelf", b =>
                {
                    b.Navigation("booksShelves");
                });

            modelBuilder.Entity("LibraryManagement.Domain.UserAgg.User", b =>
                {
                    b.Navigation("shelves");
                });
#pragma warning restore 612, 618
        }
    }
}

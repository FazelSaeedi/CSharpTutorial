using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Infrastructure.EFCore.Migrations
{
    public partial class initiallmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    isbn = table.Column<long>(type: "bigint", maxLength: 13, nullable: false),
                    isVisible = table.Column<bool>(type: "bit", nullable: false),
                    pageCount = table.Column<int>(type: "int", nullable: false),
                    CreateionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreateionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shelves",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    userId = table.Column<long>(type: "bigint", nullable: false),
                    CreateionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelves", x => x.id);
                    table.ForeignKey(
                        name: "FK_shelves_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookShelves",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shelfId = table.Column<long>(type: "bigint", nullable: false),
                    bookId = table.Column<long>(type: "bigint", nullable: false),
                    isReaded = table.Column<bool>(type: "bit", nullable: false),
                    CreateionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookShelves", x => x.id);
                    table.ForeignKey(
                        name: "FK_BookShelves_books_bookId",
                        column: x => x.bookId,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookShelves_shelves_shelfId",
                        column: x => x.shelfId,
                        principalTable: "shelves",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_isbn",
                table: "books",
                column: "isbn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_books_title",
                table: "books",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookShelves_bookId",
                table: "BookShelves",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookShelves_shelfId",
                table: "BookShelves",
                column: "shelfId");

            migrationBuilder.CreateIndex(
                name: "IX_shelves_userId",
                table: "shelves",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_users_userName",
                table: "users",
                column: "userName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookShelves");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "shelves");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}

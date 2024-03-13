using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 1, 1, "10", 1, "title1" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 2, 2, "20", 2, "title2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 3, 3, "30", 3, "title3" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 4, 4, "40", 4, "title4" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 5, 5, "50", 5, "title5" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 6, 6, "60", 6, "title6" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 7, 7, "70", 7, "title7" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 8, 8, "80", 8, "title8" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 9, 9, "90", 9, "title9" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Bookstand", "Price", "Shelf", "Title" },
                values: new object[] { 10, 10, "100", 10, "title10" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role" },
                values: new object[] { 1, "email1@email.com", "name1", "password1", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role" },
                values: new object[] { 2, "email2@email.com", "name2", "password2", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role" },
                values: new object[] { 3, "email3@email.com", "name3", "password3", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role" },
                values: new object[] { 4, "email4@email.com", "name4", "password4", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role" },
                values: new object[] { 5, "email5@email.com", "name5", "password5", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role" },
                values: new object[] { 6, "email6@email.com", "name6", "password6", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role" },
                values: new object[] { 7, "email7@email.com", "name7", "password7", 1 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 1, 1, "name1", "surname1" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 2, 2, "name2", "surname2" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 3, 3, "name3", "surname3" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 4, 4, "name4", "surname4" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 5, 5, "name5", "surname5" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 6, 6, "name6", "surname6" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 7, 7, "name7", "surname7" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 8, 8, "name8", "surname8" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 9, 9, "name9", "surname9" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 10, 10, "name10", "surname10" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 11, 1, "name11", "surname11" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 12, 2, "name12", "surname12" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 13, 3, "name13", "surname13" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 14, 4, "name14", "surname14" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 15, 5, "name15", "surname15" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 16, 6, "name16", "surname16" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 17, 7, "name17", "surname17" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 18, 8, "name18", "surname18" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 19, 9, "name19", "surname19" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BookId", "FirstName", "LastName" },
                values: new object[] { 20, 10, "name20", "surname20" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderId", "UserId" },
                values: new object[] { 1, "19b331c5-5665-4c02-914b-dde52072e33f", 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderId", "UserId" },
                values: new object[] { 2, "8e116c10-c40e-469a-95d4-7ab11c8515a1", 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderId", "UserId" },
                values: new object[] { 3, "27724367-651a-426c-8765-b75bdd29323b", 3 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderId", "UserId" },
                values: new object[] { 4, "976b89b4-e8d2-4551-994c-0c9eb338d09f", 4 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderId", "UserId" },
                values: new object[] { 5, "ba472e17-495f-40f0-bf73-c8e188c9ea7b", 5 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderId", "UserId" },
                values: new object[] { 6, "cbb4c653-2ca4-494b-8b73-5fffdf3e6f9c", 6 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderId", "UserId" },
                values: new object[] { 7, "6db03bdf-ef74-4dde-ad43-95da86832415", 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 3, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 4, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 5, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 6, 2, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 7, 2, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 8, 2, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 9, 2, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 10, 2, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 11, 3, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 12, 3, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 13, 3, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 14, 3, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 15, 3, 1 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 16, 4, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 17, 4, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 18, 4, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 19, 4, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 20, 4, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 21, 5, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 22, 5, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 23, 5, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 24, 5, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 25, 5, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 26, 6, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 27, 6, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 28, 6, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 29, 6, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 30, 6, 2 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 31, 7, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 32, 7, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 33, 7, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 34, 7, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 35, 7, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 36, 8, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 37, 8, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 38, 8, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 39, 8, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 40, 8, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 41, 9, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 42, 9, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 43, 9, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 44, 9, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 45, 9, 3 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 46, 10, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 47, 10, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 48, 10, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 49, 10, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 50, 10, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 51, 1, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 52, 1, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 53, 1, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 54, 1, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 55, 1, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 56, 2, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 57, 2, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 58, 2, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 59, 2, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 60, 2, 4 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 61, 3, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 62, 3, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 63, 3, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 64, 3, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 65, 3, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 66, 4, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 67, 4, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 68, 4, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 69, 4, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 70, 4, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 71, 5, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 72, 5, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 73, 5, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 74, 5, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 75, 5, 5 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 76, 6, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 77, 6, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 78, 6, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 79, 6, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 80, 6, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 81, 7, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 82, 7, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 83, 7, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 84, 7, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 85, 7, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 86, 8, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 87, 8, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 88, 8, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 89, 8, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 90, 8, 6 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 91, 9, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 92, 9, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 93, 9, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 94, 9, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 95, 9, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 96, 10, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 97, 10, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 98, 10, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 99, 10, 7 });

            migrationBuilder.InsertData(
                table: "OrderLine",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[] { 100, 10, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "OrderLine",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 7, "Billy Spark", "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "SWD9999002", 99.0, 90.0, 80.0, 85.0, "Zamanın Şansı" },
                    { 8, "Nancy Hoover", "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "CAW777777702", 40.0, 30.0, 20.0, 25.0, "Karanlık Gökyüzü" },
                    { 9, "Julian Button", "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "RITO5555502", 55.0, 50.0, 35.0, 40.0, "Gün Batımında Kaybolmak" },
                    { 10, "Abby Muscles", "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "WS3333333302", 70.0, 65.0, 55.0, 60.0, "Pamuk Şeker" },
                    { 11, "Ron Parker", "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "SOTJ1111111102", 30.0, 27.0, 20.0, 25.0, "Okyanusta Kaya" },
                    { 12, "Laura Phantom", "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "FOT000000002", 25.0, 23.0, 20.0, 22.0, "Yapraklar ve Harikalar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

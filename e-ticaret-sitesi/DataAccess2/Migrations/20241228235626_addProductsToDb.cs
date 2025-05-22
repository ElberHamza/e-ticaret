using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess2.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", 0, "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Zamanın Şansı" },
                    { 2, "Nancy Hoover", 0, "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Karanlık Gökyüzü" },
                    { 3, "Julian Button", 0, "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Gün Batımında Kaybolmak" },
                    { 4, "Abby Muscles", 0, "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Pamuk Şeker" },
                    { 5, "Ron Parker", 0, "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Okyanusta Kaya" },
                    { 6, "Laura Phantom", 0, "Sodales libero ile yaşayın. Orci augue molestie praesent, euismod velit sollicitudin ac ile yaşayın. Vestibulum facilisis nibh ut ultricies sunar.\r\n\r\nArtık yaşam titremesi ipsum amet tincidunt ile oturun.", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Yapraklar ve Harikalar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ÜrünId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Şehir",
                table: "AspNetUsers",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "SokakNo",
                table: "AspNetUsers",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "PostaKodu",
                table: "AspNetUsers",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "Bölge",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Adınız",
                table: "AspNetUsers",
                newName: "City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "AspNetUsers",
                newName: "Şehir");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "AspNetUsers",
                newName: "SokakNo");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "AspNetUsers",
                newName: "PostaKodu");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "Bölge");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "AspNetUsers",
                newName: "Adınız");

            migrationBuilder.AddColumn<int>(
                name: "ÜrünId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }
    }
}

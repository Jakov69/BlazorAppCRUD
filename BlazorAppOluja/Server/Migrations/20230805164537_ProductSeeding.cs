using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppOluja.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Knin pobjeda", "https://upload.wikimedia.org/wikipedia/commons/e/ed/16_obljetnica_vojnoredarstvene_operacije_Oluja_05082011_Kninska_tvrdjava_155.jpg", 9.99m, "Knin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Predaja Milana Martića", "https://upload.wikimedia.org/wikipedia/hr/4/43/Predaja_21.korpusa_SVK_1995.jpg", 7.99m, "Mile" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Operacija Oluja 95", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Map_49_-_Croatia_-_Operation_Oluja%2C_4-8_August_1995.jpg/800px-Map_49_-_Croatia_-_Operation_Oluja%2C_4-8_August_1995.jpg", 8.99m, "Oluja" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

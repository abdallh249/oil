using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace oil.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OliveOilProducts",
                columns: new[] { "Id", "Name", "PricePerLiter", "QuantityInStock", "Region" },
                values: new object[,]
                {
                    { 1, "Nablus Olive Oil", 66m, 95, "Nablus" },
                    { 2, "Jenin Olive Oil", 45m, 210, "Jenin" },
                    { 3, "Tulkarm Olive Oil", 35m, 66, "Tulkarm" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OliveOilProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OliveOilProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OliveOilProducts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

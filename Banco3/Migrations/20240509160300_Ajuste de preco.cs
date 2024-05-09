using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banco3.Migrations
{
    /// <inheritdoc />
    public partial class Ajustedepreco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Financial",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 11100.00m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Financial",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 11.100m);
        }
    }
}

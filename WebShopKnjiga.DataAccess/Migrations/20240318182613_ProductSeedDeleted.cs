using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopKnjiga.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeedDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 1, 1, "SciFi" });
        }
    }
}

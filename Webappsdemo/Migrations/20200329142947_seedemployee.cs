using Microsoft.EntityFrameworkCore.Migrations;

namespace Webappsdemo.Migrations
{
    public partial class seedemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CatelogType", "Department", "ProductName" },
                values: new object[] { 34, "Ele", 1, "TV" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class datasetcentre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Centre",
                columns: new[] { "Id", "AdressId", "Name", "ResponsableId" },
                values: new object[] { 1, 1, "Namur Expo", 1 });

            migrationBuilder.InsertData(
                table: "Centre",
                columns: new[] { "Id", "AdressId", "Name", "ResponsableId" },
                values: new object[] { 2, 2, "Centre Central", 5 });

            migrationBuilder.InsertData(
                table: "Centre",
                columns: new[] { "Id", "AdressId", "Name", "ResponsableId" },
                values: new object[] { 3, 3, "Hall Saint-Servais", 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Centre",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Centre",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Centre",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

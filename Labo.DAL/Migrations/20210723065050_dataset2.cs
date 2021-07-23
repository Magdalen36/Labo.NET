using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class dataset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Injection",
                columns: new[] { "Id", "CalendrierHeureId", "LotVaccinId", "PatientId", "PersonnelId" },
                values: new object[,]
                {
                    { 1, 1, null, 1, null },
                    { 2, 2, null, 2, null },
                    { 3, 3, null, 3, null },
                    { 4, 4, null, 4, null },
                    { 5, 5, null, 5, null },
                    { 6, 6, null, 6, null },
                    { 7, 7, null, 7, null },
                    { 8, 8, null, 8, null },
                    { 9, 9, null, 9, null },
                    { 10, 10, null, 10, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Injection",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

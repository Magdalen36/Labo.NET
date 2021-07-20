using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class datasetgradeEtTypeVaccin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Médecin" },
                    { 2, "Infirmier" },
                    { 3, "Sécurité" },
                    { 4, "Bénévole" }
                });

            migrationBuilder.InsertData(
                table: "TypeVaccin",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Moderna" },
                    { 2, "Pfizer" },
                    { 3, "Johnson & Johnson" },
                    { 4, "AstraZeneca" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TypeVaccin",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypeVaccin",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypeVaccin",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TypeVaccin",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

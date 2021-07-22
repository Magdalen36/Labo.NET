using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class dataset1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Centre",
                columns: new[] { "Id", "AdressId", "Name", "ResponsableId" },
                values: new object[,]
                {
                    { 1, 1, "Namur Expo", 1 },
                    { 2, 2, "Centre Central", 5 },
                    { 3, 3, "Hall Saint-Servais", 9 }
                });

            migrationBuilder.InsertData(
                table: "Fournisseur",
                columns: new[] { "Id", "AdressId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 199, "Julie", "Edouard" },
                    { 2, 198, "Sophie", "Dufranne" },
                    { 3, 197, "Pierre", "Braboa" },
                    { 4, 196, "Max", "Vanden" }
                });

            migrationBuilder.InsertData(
                table: "HeureOuverture",
                columns: new[] { "Id", "CentreId", "HeureDebut", "HeureFin", "Jour" },
                values: new object[,]
                {
                    { 1, 1, 8, 20, 1 },
                    { 16, 3, 8, 20, 3 },
                    { 15, 3, 8, 20, 2 },
                    { 14, 3, 8, 20, 1 },
                    { 13, 2, 7, 18, 7 },
                    { 12, 2, 7, 18, 6 },
                    { 11, 2, 7, 18, 5 },
                    { 10, 2, 7, 18, 4 },
                    { 9, 2, 7, 18, 2 },
                    { 8, 2, 7, 18, 1 },
                    { 7, 1, 8, 22, 7 },
                    { 6, 1, 8, 20, 6 },
                    { 5, 1, 8, 20, 5 },
                    { 4, 1, 8, 20, 4 },
                    { 3, 1, 8, 20, 3 },
                    { 2, 1, 8, 20, 2 },
                    { 17, 3, 8, 20, 4 },
                    { 18, 3, 8, 22, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fournisseur",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fournisseur",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fournisseur",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fournisseur",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HeureOuverture",
                keyColumn: "Id",
                keyValue: 18);

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

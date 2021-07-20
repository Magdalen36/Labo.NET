using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class dataset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateSortie",
                table: "LotVaccin",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                    { 16, 3, 8, 20, 3 },
                    { 15, 3, 8, 20, 2 },
                    { 14, 3, 8, 20, 1 },
                    { 13, 2, 7, 18, 7 },
                    { 12, 2, 7, 18, 6 },
                    { 11, 2, 7, 18, 5 },
                    { 10, 2, 7, 18, 4 },
                    { 9, 2, 7, 18, 2 },
                    { 7, 1, 8, 22, 7 },
                    { 17, 3, 8, 20, 4 },
                    { 6, 1, 8, 20, 6 },
                    { 5, 1, 8, 20, 5 },
                    { 4, 1, 8, 20, 4 },
                    { 3, 1, 8, 20, 3 },
                    { 2, 1, 8, 20, 2 },
                    { 1, 1, 8, 20, 1 },
                    { 8, 2, 7, 18, 1 },
                    { 18, 3, 8, 22, 5 }
                });

            migrationBuilder.InsertData(
                table: "LotVaccin",
                columns: new[] { "Id", "CentreId", "DateEntree", "DateSortie", "FournisseurId", "QuantiteEntree", "QuantiteRestante", "TypeVaccinId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 20, 20, 1 },
                    { 5, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 30, 30, 1 },
                    { 2, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 40, 40, 2 },
                    { 6, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 50, 50, 2 },
                    { 3, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 60, 60, 3 },
                    { 4, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 10, 10, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "LotVaccin",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LotVaccin",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LotVaccin",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LotVaccin",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LotVaccin",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LotVaccin",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateSortie",
                table: "LotVaccin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}

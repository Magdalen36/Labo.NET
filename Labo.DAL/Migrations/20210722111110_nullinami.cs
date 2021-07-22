using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class nullinami : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Inami",
                table: "Personnel",
                type: "bigint",
                fixedLength: true,
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldFixedLength: true,
                oldMaxLength: 11);

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2021, 7, 23, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2021, 7, 24, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2021, 7, 25, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2021, 7, 26, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2021, 7, 27, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2021, 7, 28, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2021, 7, 29, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2021, 7, 30, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2021, 7, 31, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2021, 8, 1, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2021, 8, 2, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2021, 8, 3, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2021, 8, 4, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2021, 8, 5, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2021, 8, 6, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2021, 8, 7, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2021, 8, 8, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2021, 8, 9, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2021, 8, 10, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2021, 8, 11, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2021, 8, 12, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2021, 8, 13, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2021, 8, 14, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2021, 8, 15, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2021, 8, 16, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2021, 8, 17, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2021, 8, 18, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 28,
                column: "Day",
                value: new DateTime(2021, 8, 19, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 29,
                column: "Day",
                value: new DateTime(2021, 8, 20, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 30,
                column: "Day",
                value: new DateTime(2021, 8, 21, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 31,
                column: "Day",
                value: new DateTime(2021, 8, 22, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 32,
                column: "Day",
                value: new DateTime(2021, 8, 23, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 33,
                column: "Day",
                value: new DateTime(2021, 8, 24, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 34,
                column: "Day",
                value: new DateTime(2021, 8, 25, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 35,
                column: "Day",
                value: new DateTime(2021, 8, 26, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 36,
                column: "Day",
                value: new DateTime(2021, 8, 27, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 37,
                column: "Day",
                value: new DateTime(2021, 8, 28, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 38,
                column: "Day",
                value: new DateTime(2021, 8, 29, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 39,
                column: "Day",
                value: new DateTime(2021, 8, 30, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 40,
                column: "Day",
                value: new DateTime(2021, 8, 31, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 41,
                column: "Day",
                value: new DateTime(2021, 9, 1, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 42,
                column: "Day",
                value: new DateTime(2021, 9, 2, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 43,
                column: "Day",
                value: new DateTime(2021, 9, 3, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 44,
                column: "Day",
                value: new DateTime(2021, 9, 4, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 45,
                column: "Day",
                value: new DateTime(2021, 9, 5, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 46,
                column: "Day",
                value: new DateTime(2021, 9, 6, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 47,
                column: "Day",
                value: new DateTime(2021, 9, 7, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 48,
                column: "Day",
                value: new DateTime(2021, 9, 8, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 49,
                column: "Day",
                value: new DateTime(2021, 9, 9, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 50,
                column: "Day",
                value: new DateTime(2021, 9, 10, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 51,
                column: "Day",
                value: new DateTime(2021, 9, 11, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 52,
                column: "Day",
                value: new DateTime(2021, 9, 12, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 53,
                column: "Day",
                value: new DateTime(2021, 9, 13, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 54,
                column: "Day",
                value: new DateTime(2021, 9, 14, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 55,
                column: "Day",
                value: new DateTime(2021, 9, 15, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 56,
                column: "Day",
                value: new DateTime(2021, 9, 16, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 57,
                column: "Day",
                value: new DateTime(2021, 9, 17, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 58,
                column: "Day",
                value: new DateTime(2021, 9, 18, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 59,
                column: "Day",
                value: new DateTime(2021, 9, 19, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 60,
                column: "Day",
                value: new DateTime(2021, 9, 20, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 61,
                column: "Day",
                value: new DateTime(2021, 9, 21, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 62,
                column: "Day",
                value: new DateTime(2021, 9, 22, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 63,
                column: "Day",
                value: new DateTime(2021, 9, 23, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 64,
                column: "Day",
                value: new DateTime(2021, 9, 24, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 65,
                column: "Day",
                value: new DateTime(2021, 9, 25, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 66,
                column: "Day",
                value: new DateTime(2021, 9, 26, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 67,
                column: "Day",
                value: new DateTime(2021, 9, 27, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 68,
                column: "Day",
                value: new DateTime(2021, 9, 28, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 69,
                column: "Day",
                value: new DateTime(2021, 9, 29, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 70,
                column: "Day",
                value: new DateTime(2021, 9, 30, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 71,
                column: "Day",
                value: new DateTime(2021, 10, 1, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 72,
                column: "Day",
                value: new DateTime(2021, 10, 2, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 73,
                column: "Day",
                value: new DateTime(2021, 10, 3, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 74,
                column: "Day",
                value: new DateTime(2021, 10, 4, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 75,
                column: "Day",
                value: new DateTime(2021, 10, 5, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 76,
                column: "Day",
                value: new DateTime(2021, 10, 6, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 77,
                column: "Day",
                value: new DateTime(2021, 10, 7, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 78,
                column: "Day",
                value: new DateTime(2021, 10, 8, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 79,
                column: "Day",
                value: new DateTime(2021, 10, 9, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 80,
                column: "Day",
                value: new DateTime(2021, 10, 10, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 81,
                column: "Day",
                value: new DateTime(2021, 10, 11, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 82,
                column: "Day",
                value: new DateTime(2021, 10, 12, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 83,
                column: "Day",
                value: new DateTime(2021, 10, 13, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 84,
                column: "Day",
                value: new DateTime(2021, 10, 14, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 85,
                column: "Day",
                value: new DateTime(2021, 10, 15, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 86,
                column: "Day",
                value: new DateTime(2021, 10, 16, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 87,
                column: "Day",
                value: new DateTime(2021, 10, 17, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 88,
                column: "Day",
                value: new DateTime(2021, 10, 18, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 89,
                column: "Day",
                value: new DateTime(2021, 10, 19, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 90,
                column: "Day",
                value: new DateTime(2021, 10, 20, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 91,
                column: "Day",
                value: new DateTime(2021, 10, 21, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 92,
                column: "Day",
                value: new DateTime(2021, 10, 22, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 93,
                column: "Day",
                value: new DateTime(2021, 10, 23, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 94,
                column: "Day",
                value: new DateTime(2021, 10, 24, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 95,
                column: "Day",
                value: new DateTime(2021, 10, 25, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 96,
                column: "Day",
                value: new DateTime(2021, 10, 26, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 97,
                column: "Day",
                value: new DateTime(2021, 10, 27, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 98,
                column: "Day",
                value: new DateTime(2021, 10, 28, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 99,
                column: "Day",
                value: new DateTime(2021, 10, 29, 13, 11, 9, 347, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 100,
                column: "Day",
                value: new DateTime(2021, 7, 23, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 101,
                column: "Day",
                value: new DateTime(2021, 7, 24, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 102,
                column: "Day",
                value: new DateTime(2021, 7, 25, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 103,
                column: "Day",
                value: new DateTime(2021, 7, 26, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 104,
                column: "Day",
                value: new DateTime(2021, 7, 27, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 106,
                column: "Day",
                value: new DateTime(2021, 7, 29, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 107,
                column: "Day",
                value: new DateTime(2021, 7, 30, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 108,
                column: "Day",
                value: new DateTime(2021, 7, 31, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 109,
                column: "Day",
                value: new DateTime(2021, 8, 1, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 110,
                column: "Day",
                value: new DateTime(2021, 8, 2, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 111,
                column: "Day",
                value: new DateTime(2021, 8, 3, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 113,
                column: "Day",
                value: new DateTime(2021, 8, 5, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 114,
                column: "Day",
                value: new DateTime(2021, 8, 6, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 115,
                column: "Day",
                value: new DateTime(2021, 8, 7, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 116,
                column: "Day",
                value: new DateTime(2021, 8, 8, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 117,
                column: "Day",
                value: new DateTime(2021, 8, 9, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 118,
                column: "Day",
                value: new DateTime(2021, 8, 10, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 120,
                column: "Day",
                value: new DateTime(2021, 8, 12, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 121,
                column: "Day",
                value: new DateTime(2021, 8, 13, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 122,
                column: "Day",
                value: new DateTime(2021, 8, 14, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 123,
                column: "Day",
                value: new DateTime(2021, 8, 15, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 124,
                column: "Day",
                value: new DateTime(2021, 8, 16, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 125,
                column: "Day",
                value: new DateTime(2021, 8, 17, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 127,
                column: "Day",
                value: new DateTime(2021, 8, 19, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 128,
                column: "Day",
                value: new DateTime(2021, 8, 20, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 129,
                column: "Day",
                value: new DateTime(2021, 8, 21, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 130,
                column: "Day",
                value: new DateTime(2021, 8, 22, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 131,
                column: "Day",
                value: new DateTime(2021, 8, 23, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 132,
                column: "Day",
                value: new DateTime(2021, 8, 24, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 134,
                column: "Day",
                value: new DateTime(2021, 8, 26, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 135,
                column: "Day",
                value: new DateTime(2021, 8, 27, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 136,
                column: "Day",
                value: new DateTime(2021, 8, 28, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 137,
                column: "Day",
                value: new DateTime(2021, 8, 29, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 138,
                column: "Day",
                value: new DateTime(2021, 8, 30, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 139,
                column: "Day",
                value: new DateTime(2021, 8, 31, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 141,
                column: "Day",
                value: new DateTime(2021, 9, 2, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 142,
                column: "Day",
                value: new DateTime(2021, 9, 3, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 143,
                column: "Day",
                value: new DateTime(2021, 9, 4, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 144,
                column: "Day",
                value: new DateTime(2021, 9, 5, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 145,
                column: "Day",
                value: new DateTime(2021, 9, 6, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 146,
                column: "Day",
                value: new DateTime(2021, 9, 7, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 148,
                column: "Day",
                value: new DateTime(2021, 9, 9, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 149,
                column: "Day",
                value: new DateTime(2021, 9, 10, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 150,
                column: "Day",
                value: new DateTime(2021, 9, 11, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 151,
                column: "Day",
                value: new DateTime(2021, 9, 12, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 152,
                column: "Day",
                value: new DateTime(2021, 9, 13, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 153,
                column: "Day",
                value: new DateTime(2021, 9, 14, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 155,
                column: "Day",
                value: new DateTime(2021, 9, 16, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 156,
                column: "Day",
                value: new DateTime(2021, 9, 17, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 157,
                column: "Day",
                value: new DateTime(2021, 9, 18, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 158,
                column: "Day",
                value: new DateTime(2021, 9, 19, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 159,
                column: "Day",
                value: new DateTime(2021, 9, 20, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 160,
                column: "Day",
                value: new DateTime(2021, 9, 21, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 162,
                column: "Day",
                value: new DateTime(2021, 9, 23, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 163,
                column: "Day",
                value: new DateTime(2021, 9, 24, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 164,
                column: "Day",
                value: new DateTime(2021, 9, 25, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 165,
                column: "Day",
                value: new DateTime(2021, 9, 26, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 166,
                column: "Day",
                value: new DateTime(2021, 9, 27, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 167,
                column: "Day",
                value: new DateTime(2021, 9, 28, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 169,
                column: "Day",
                value: new DateTime(2021, 9, 30, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 170,
                column: "Day",
                value: new DateTime(2021, 10, 1, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 171,
                column: "Day",
                value: new DateTime(2021, 10, 2, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 172,
                column: "Day",
                value: new DateTime(2021, 10, 3, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 173,
                column: "Day",
                value: new DateTime(2021, 10, 4, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 174,
                column: "Day",
                value: new DateTime(2021, 10, 5, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 176,
                column: "Day",
                value: new DateTime(2021, 10, 7, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 177,
                column: "Day",
                value: new DateTime(2021, 10, 8, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 178,
                column: "Day",
                value: new DateTime(2021, 10, 9, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 179,
                column: "Day",
                value: new DateTime(2021, 10, 10, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 180,
                column: "Day",
                value: new DateTime(2021, 10, 11, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 181,
                column: "Day",
                value: new DateTime(2021, 10, 12, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 183,
                column: "Day",
                value: new DateTime(2021, 10, 14, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 184,
                column: "Day",
                value: new DateTime(2021, 10, 15, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 185,
                column: "Day",
                value: new DateTime(2021, 10, 16, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 186,
                column: "Day",
                value: new DateTime(2021, 10, 17, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 187,
                column: "Day",
                value: new DateTime(2021, 10, 18, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 188,
                column: "Day",
                value: new DateTime(2021, 10, 19, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 190,
                column: "Day",
                value: new DateTime(2021, 10, 21, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 191,
                column: "Day",
                value: new DateTime(2021, 10, 22, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 192,
                column: "Day",
                value: new DateTime(2021, 10, 23, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 193,
                column: "Day",
                value: new DateTime(2021, 10, 24, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 194,
                column: "Day",
                value: new DateTime(2021, 10, 25, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 195,
                column: "Day",
                value: new DateTime(2021, 10, 26, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 197,
                column: "Day",
                value: new DateTime(2021, 10, 28, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 198,
                column: "Day",
                value: new DateTime(2021, 10, 29, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 199,
                column: "Day",
                value: new DateTime(2021, 10, 30, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 200,
                column: "Day",
                value: new DateTime(2021, 7, 23, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 202,
                column: "Day",
                value: new DateTime(2021, 7, 25, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 203,
                column: "Day",
                value: new DateTime(2021, 7, 26, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 204,
                column: "Day",
                value: new DateTime(2021, 7, 27, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 205,
                column: "Day",
                value: new DateTime(2021, 7, 28, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 206,
                column: "Day",
                value: new DateTime(2021, 7, 29, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 207,
                column: "Day",
                value: new DateTime(2021, 7, 30, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 209,
                column: "Day",
                value: new DateTime(2021, 8, 1, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 210,
                column: "Day",
                value: new DateTime(2021, 8, 2, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 211,
                column: "Day",
                value: new DateTime(2021, 8, 3, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 212,
                column: "Day",
                value: new DateTime(2021, 8, 4, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 213,
                column: "Day",
                value: new DateTime(2021, 8, 5, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 214,
                column: "Day",
                value: new DateTime(2021, 8, 6, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 216,
                column: "Day",
                value: new DateTime(2021, 8, 8, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 217,
                column: "Day",
                value: new DateTime(2021, 8, 9, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 218,
                column: "Day",
                value: new DateTime(2021, 8, 10, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 219,
                column: "Day",
                value: new DateTime(2021, 8, 11, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 220,
                column: "Day",
                value: new DateTime(2021, 8, 12, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 221,
                column: "Day",
                value: new DateTime(2021, 8, 13, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 223,
                column: "Day",
                value: new DateTime(2021, 8, 15, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 224,
                column: "Day",
                value: new DateTime(2021, 8, 16, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 225,
                column: "Day",
                value: new DateTime(2021, 8, 17, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 226,
                column: "Day",
                value: new DateTime(2021, 8, 18, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 227,
                column: "Day",
                value: new DateTime(2021, 8, 19, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 228,
                column: "Day",
                value: new DateTime(2021, 8, 20, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 230,
                column: "Day",
                value: new DateTime(2021, 8, 22, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 231,
                column: "Day",
                value: new DateTime(2021, 8, 23, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 232,
                column: "Day",
                value: new DateTime(2021, 8, 24, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 233,
                column: "Day",
                value: new DateTime(2021, 8, 25, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 234,
                column: "Day",
                value: new DateTime(2021, 8, 26, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 235,
                column: "Day",
                value: new DateTime(2021, 8, 27, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 237,
                column: "Day",
                value: new DateTime(2021, 8, 29, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 238,
                column: "Day",
                value: new DateTime(2021, 8, 30, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 239,
                column: "Day",
                value: new DateTime(2021, 8, 31, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 240,
                column: "Day",
                value: new DateTime(2021, 9, 1, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 241,
                column: "Day",
                value: new DateTime(2021, 9, 2, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 242,
                column: "Day",
                value: new DateTime(2021, 9, 3, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 244,
                column: "Day",
                value: new DateTime(2021, 9, 5, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 245,
                column: "Day",
                value: new DateTime(2021, 9, 6, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 246,
                column: "Day",
                value: new DateTime(2021, 9, 7, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 247,
                column: "Day",
                value: new DateTime(2021, 9, 8, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 248,
                column: "Day",
                value: new DateTime(2021, 9, 9, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 249,
                column: "Day",
                value: new DateTime(2021, 9, 10, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 251,
                column: "Day",
                value: new DateTime(2021, 9, 12, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 252,
                column: "Day",
                value: new DateTime(2021, 9, 13, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 253,
                column: "Day",
                value: new DateTime(2021, 9, 14, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 254,
                column: "Day",
                value: new DateTime(2021, 9, 15, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 255,
                column: "Day",
                value: new DateTime(2021, 9, 16, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 256,
                column: "Day",
                value: new DateTime(2021, 9, 17, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 258,
                column: "Day",
                value: new DateTime(2021, 9, 19, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 259,
                column: "Day",
                value: new DateTime(2021, 9, 20, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 260,
                column: "Day",
                value: new DateTime(2021, 9, 21, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 261,
                column: "Day",
                value: new DateTime(2021, 9, 22, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 262,
                column: "Day",
                value: new DateTime(2021, 9, 23, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 263,
                column: "Day",
                value: new DateTime(2021, 9, 24, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 265,
                column: "Day",
                value: new DateTime(2021, 9, 26, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 266,
                column: "Day",
                value: new DateTime(2021, 9, 27, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 267,
                column: "Day",
                value: new DateTime(2021, 9, 28, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 268,
                column: "Day",
                value: new DateTime(2021, 9, 29, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 269,
                column: "Day",
                value: new DateTime(2021, 9, 30, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 270,
                column: "Day",
                value: new DateTime(2021, 10, 1, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 272,
                column: "Day",
                value: new DateTime(2021, 10, 3, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 273,
                column: "Day",
                value: new DateTime(2021, 10, 4, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 274,
                column: "Day",
                value: new DateTime(2021, 10, 5, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 275,
                column: "Day",
                value: new DateTime(2021, 10, 6, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 276,
                column: "Day",
                value: new DateTime(2021, 10, 7, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 277,
                column: "Day",
                value: new DateTime(2021, 10, 8, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 279,
                column: "Day",
                value: new DateTime(2021, 10, 10, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 280,
                column: "Day",
                value: new DateTime(2021, 10, 11, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 281,
                column: "Day",
                value: new DateTime(2021, 10, 12, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 282,
                column: "Day",
                value: new DateTime(2021, 10, 13, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 283,
                column: "Day",
                value: new DateTime(2021, 10, 14, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 284,
                column: "Day",
                value: new DateTime(2021, 10, 15, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 286,
                column: "Day",
                value: new DateTime(2021, 10, 17, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 287,
                column: "Day",
                value: new DateTime(2021, 10, 18, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 288,
                column: "Day",
                value: new DateTime(2021, 10, 19, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 289,
                column: "Day",
                value: new DateTime(2021, 10, 20, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 290,
                column: "Day",
                value: new DateTime(2021, 10, 21, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 291,
                column: "Day",
                value: new DateTime(2021, 10, 22, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 293,
                column: "Day",
                value: new DateTime(2021, 10, 24, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 294,
                column: "Day",
                value: new DateTime(2021, 10, 25, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 295,
                column: "Day",
                value: new DateTime(2021, 10, 26, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 296,
                column: "Day",
                value: new DateTime(2021, 10, 27, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 297,
                column: "Day",
                value: new DateTime(2021, 10, 28, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 298,
                column: "Day",
                value: new DateTime(2021, 10, 29, 13, 11, 9, 349, DateTimeKind.Local).AddTicks(8329));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Inami",
                table: "Personnel",
                type: "bigint",
                fixedLength: true,
                maxLength: 11,
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldFixedLength: true,
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 1,
                column: "Day",
                value: new DateTime(2021, 7, 23, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 2,
                column: "Day",
                value: new DateTime(2021, 7, 24, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 3,
                column: "Day",
                value: new DateTime(2021, 7, 25, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 4,
                column: "Day",
                value: new DateTime(2021, 7, 26, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 5,
                column: "Day",
                value: new DateTime(2021, 7, 27, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 6,
                column: "Day",
                value: new DateTime(2021, 7, 28, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 7,
                column: "Day",
                value: new DateTime(2021, 7, 29, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 8,
                column: "Day",
                value: new DateTime(2021, 7, 30, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 9,
                column: "Day",
                value: new DateTime(2021, 7, 31, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 10,
                column: "Day",
                value: new DateTime(2021, 8, 1, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 11,
                column: "Day",
                value: new DateTime(2021, 8, 2, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 12,
                column: "Day",
                value: new DateTime(2021, 8, 3, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 13,
                column: "Day",
                value: new DateTime(2021, 8, 4, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 14,
                column: "Day",
                value: new DateTime(2021, 8, 5, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 15,
                column: "Day",
                value: new DateTime(2021, 8, 6, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 16,
                column: "Day",
                value: new DateTime(2021, 8, 7, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 17,
                column: "Day",
                value: new DateTime(2021, 8, 8, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 18,
                column: "Day",
                value: new DateTime(2021, 8, 9, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 19,
                column: "Day",
                value: new DateTime(2021, 8, 10, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 20,
                column: "Day",
                value: new DateTime(2021, 8, 11, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 21,
                column: "Day",
                value: new DateTime(2021, 8, 12, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 22,
                column: "Day",
                value: new DateTime(2021, 8, 13, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 23,
                column: "Day",
                value: new DateTime(2021, 8, 14, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 24,
                column: "Day",
                value: new DateTime(2021, 8, 15, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 25,
                column: "Day",
                value: new DateTime(2021, 8, 16, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 26,
                column: "Day",
                value: new DateTime(2021, 8, 17, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 27,
                column: "Day",
                value: new DateTime(2021, 8, 18, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 28,
                column: "Day",
                value: new DateTime(2021, 8, 19, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 29,
                column: "Day",
                value: new DateTime(2021, 8, 20, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 30,
                column: "Day",
                value: new DateTime(2021, 8, 21, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 31,
                column: "Day",
                value: new DateTime(2021, 8, 22, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 32,
                column: "Day",
                value: new DateTime(2021, 8, 23, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 33,
                column: "Day",
                value: new DateTime(2021, 8, 24, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 34,
                column: "Day",
                value: new DateTime(2021, 8, 25, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 35,
                column: "Day",
                value: new DateTime(2021, 8, 26, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 36,
                column: "Day",
                value: new DateTime(2021, 8, 27, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 37,
                column: "Day",
                value: new DateTime(2021, 8, 28, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 38,
                column: "Day",
                value: new DateTime(2021, 8, 29, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 39,
                column: "Day",
                value: new DateTime(2021, 8, 30, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 40,
                column: "Day",
                value: new DateTime(2021, 8, 31, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 41,
                column: "Day",
                value: new DateTime(2021, 9, 1, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 42,
                column: "Day",
                value: new DateTime(2021, 9, 2, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 43,
                column: "Day",
                value: new DateTime(2021, 9, 3, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 44,
                column: "Day",
                value: new DateTime(2021, 9, 4, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 45,
                column: "Day",
                value: new DateTime(2021, 9, 5, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 46,
                column: "Day",
                value: new DateTime(2021, 9, 6, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 47,
                column: "Day",
                value: new DateTime(2021, 9, 7, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 48,
                column: "Day",
                value: new DateTime(2021, 9, 8, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 49,
                column: "Day",
                value: new DateTime(2021, 9, 9, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 50,
                column: "Day",
                value: new DateTime(2021, 9, 10, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 51,
                column: "Day",
                value: new DateTime(2021, 9, 11, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 52,
                column: "Day",
                value: new DateTime(2021, 9, 12, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 53,
                column: "Day",
                value: new DateTime(2021, 9, 13, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 54,
                column: "Day",
                value: new DateTime(2021, 9, 14, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 55,
                column: "Day",
                value: new DateTime(2021, 9, 15, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 56,
                column: "Day",
                value: new DateTime(2021, 9, 16, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 57,
                column: "Day",
                value: new DateTime(2021, 9, 17, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 58,
                column: "Day",
                value: new DateTime(2021, 9, 18, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 59,
                column: "Day",
                value: new DateTime(2021, 9, 19, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 60,
                column: "Day",
                value: new DateTime(2021, 9, 20, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 61,
                column: "Day",
                value: new DateTime(2021, 9, 21, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 62,
                column: "Day",
                value: new DateTime(2021, 9, 22, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 63,
                column: "Day",
                value: new DateTime(2021, 9, 23, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 64,
                column: "Day",
                value: new DateTime(2021, 9, 24, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 65,
                column: "Day",
                value: new DateTime(2021, 9, 25, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 66,
                column: "Day",
                value: new DateTime(2021, 9, 26, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 67,
                column: "Day",
                value: new DateTime(2021, 9, 27, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 68,
                column: "Day",
                value: new DateTime(2021, 9, 28, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 69,
                column: "Day",
                value: new DateTime(2021, 9, 29, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 70,
                column: "Day",
                value: new DateTime(2021, 9, 30, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 71,
                column: "Day",
                value: new DateTime(2021, 10, 1, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 72,
                column: "Day",
                value: new DateTime(2021, 10, 2, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 73,
                column: "Day",
                value: new DateTime(2021, 10, 3, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 74,
                column: "Day",
                value: new DateTime(2021, 10, 4, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 75,
                column: "Day",
                value: new DateTime(2021, 10, 5, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 76,
                column: "Day",
                value: new DateTime(2021, 10, 6, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 77,
                column: "Day",
                value: new DateTime(2021, 10, 7, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 78,
                column: "Day",
                value: new DateTime(2021, 10, 8, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 79,
                column: "Day",
                value: new DateTime(2021, 10, 9, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 80,
                column: "Day",
                value: new DateTime(2021, 10, 10, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 81,
                column: "Day",
                value: new DateTime(2021, 10, 11, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 82,
                column: "Day",
                value: new DateTime(2021, 10, 12, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 83,
                column: "Day",
                value: new DateTime(2021, 10, 13, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 84,
                column: "Day",
                value: new DateTime(2021, 10, 14, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 85,
                column: "Day",
                value: new DateTime(2021, 10, 15, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 86,
                column: "Day",
                value: new DateTime(2021, 10, 16, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 87,
                column: "Day",
                value: new DateTime(2021, 10, 17, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 88,
                column: "Day",
                value: new DateTime(2021, 10, 18, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 89,
                column: "Day",
                value: new DateTime(2021, 10, 19, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 90,
                column: "Day",
                value: new DateTime(2021, 10, 20, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 91,
                column: "Day",
                value: new DateTime(2021, 10, 21, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 92,
                column: "Day",
                value: new DateTime(2021, 10, 22, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 93,
                column: "Day",
                value: new DateTime(2021, 10, 23, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 94,
                column: "Day",
                value: new DateTime(2021, 10, 24, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 95,
                column: "Day",
                value: new DateTime(2021, 10, 25, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 96,
                column: "Day",
                value: new DateTime(2021, 10, 26, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 97,
                column: "Day",
                value: new DateTime(2021, 10, 27, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 98,
                column: "Day",
                value: new DateTime(2021, 10, 28, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 99,
                column: "Day",
                value: new DateTime(2021, 10, 29, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 100,
                column: "Day",
                value: new DateTime(2021, 7, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 101,
                column: "Day",
                value: new DateTime(2021, 7, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 102,
                column: "Day",
                value: new DateTime(2021, 7, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 103,
                column: "Day",
                value: new DateTime(2021, 7, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 104,
                column: "Day",
                value: new DateTime(2021, 7, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 106,
                column: "Day",
                value: new DateTime(2021, 7, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 107,
                column: "Day",
                value: new DateTime(2021, 7, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 108,
                column: "Day",
                value: new DateTime(2021, 7, 31, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 109,
                column: "Day",
                value: new DateTime(2021, 8, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 110,
                column: "Day",
                value: new DateTime(2021, 8, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 111,
                column: "Day",
                value: new DateTime(2021, 8, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 113,
                column: "Day",
                value: new DateTime(2021, 8, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 114,
                column: "Day",
                value: new DateTime(2021, 8, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 115,
                column: "Day",
                value: new DateTime(2021, 8, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 116,
                column: "Day",
                value: new DateTime(2021, 8, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 117,
                column: "Day",
                value: new DateTime(2021, 8, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 118,
                column: "Day",
                value: new DateTime(2021, 8, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 120,
                column: "Day",
                value: new DateTime(2021, 8, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 121,
                column: "Day",
                value: new DateTime(2021, 8, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 122,
                column: "Day",
                value: new DateTime(2021, 8, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 123,
                column: "Day",
                value: new DateTime(2021, 8, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 124,
                column: "Day",
                value: new DateTime(2021, 8, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 125,
                column: "Day",
                value: new DateTime(2021, 8, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 127,
                column: "Day",
                value: new DateTime(2021, 8, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 128,
                column: "Day",
                value: new DateTime(2021, 8, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 129,
                column: "Day",
                value: new DateTime(2021, 8, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 130,
                column: "Day",
                value: new DateTime(2021, 8, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 131,
                column: "Day",
                value: new DateTime(2021, 8, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 132,
                column: "Day",
                value: new DateTime(2021, 8, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 134,
                column: "Day",
                value: new DateTime(2021, 8, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 135,
                column: "Day",
                value: new DateTime(2021, 8, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 136,
                column: "Day",
                value: new DateTime(2021, 8, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 137,
                column: "Day",
                value: new DateTime(2021, 8, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 138,
                column: "Day",
                value: new DateTime(2021, 8, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 139,
                column: "Day",
                value: new DateTime(2021, 8, 31, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 141,
                column: "Day",
                value: new DateTime(2021, 9, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 142,
                column: "Day",
                value: new DateTime(2021, 9, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 143,
                column: "Day",
                value: new DateTime(2021, 9, 4, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 144,
                column: "Day",
                value: new DateTime(2021, 9, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 145,
                column: "Day",
                value: new DateTime(2021, 9, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 146,
                column: "Day",
                value: new DateTime(2021, 9, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 148,
                column: "Day",
                value: new DateTime(2021, 9, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 149,
                column: "Day",
                value: new DateTime(2021, 9, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 150,
                column: "Day",
                value: new DateTime(2021, 9, 11, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 151,
                column: "Day",
                value: new DateTime(2021, 9, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 152,
                column: "Day",
                value: new DateTime(2021, 9, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 153,
                column: "Day",
                value: new DateTime(2021, 9, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 155,
                column: "Day",
                value: new DateTime(2021, 9, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 156,
                column: "Day",
                value: new DateTime(2021, 9, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 157,
                column: "Day",
                value: new DateTime(2021, 9, 18, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 158,
                column: "Day",
                value: new DateTime(2021, 9, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 159,
                column: "Day",
                value: new DateTime(2021, 9, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 160,
                column: "Day",
                value: new DateTime(2021, 9, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 162,
                column: "Day",
                value: new DateTime(2021, 9, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 163,
                column: "Day",
                value: new DateTime(2021, 9, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 164,
                column: "Day",
                value: new DateTime(2021, 9, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 165,
                column: "Day",
                value: new DateTime(2021, 9, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 166,
                column: "Day",
                value: new DateTime(2021, 9, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 167,
                column: "Day",
                value: new DateTime(2021, 9, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 169,
                column: "Day",
                value: new DateTime(2021, 9, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 170,
                column: "Day",
                value: new DateTime(2021, 10, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 171,
                column: "Day",
                value: new DateTime(2021, 10, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 172,
                column: "Day",
                value: new DateTime(2021, 10, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 173,
                column: "Day",
                value: new DateTime(2021, 10, 4, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 174,
                column: "Day",
                value: new DateTime(2021, 10, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 176,
                column: "Day",
                value: new DateTime(2021, 10, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 177,
                column: "Day",
                value: new DateTime(2021, 10, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 178,
                column: "Day",
                value: new DateTime(2021, 10, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 179,
                column: "Day",
                value: new DateTime(2021, 10, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 180,
                column: "Day",
                value: new DateTime(2021, 10, 11, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 181,
                column: "Day",
                value: new DateTime(2021, 10, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 183,
                column: "Day",
                value: new DateTime(2021, 10, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 184,
                column: "Day",
                value: new DateTime(2021, 10, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 185,
                column: "Day",
                value: new DateTime(2021, 10, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 186,
                column: "Day",
                value: new DateTime(2021, 10, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 187,
                column: "Day",
                value: new DateTime(2021, 10, 18, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 188,
                column: "Day",
                value: new DateTime(2021, 10, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 190,
                column: "Day",
                value: new DateTime(2021, 10, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 191,
                column: "Day",
                value: new DateTime(2021, 10, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 192,
                column: "Day",
                value: new DateTime(2021, 10, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 193,
                column: "Day",
                value: new DateTime(2021, 10, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 194,
                column: "Day",
                value: new DateTime(2021, 10, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 195,
                column: "Day",
                value: new DateTime(2021, 10, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 197,
                column: "Day",
                value: new DateTime(2021, 10, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 198,
                column: "Day",
                value: new DateTime(2021, 10, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 199,
                column: "Day",
                value: new DateTime(2021, 10, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 200,
                column: "Day",
                value: new DateTime(2021, 7, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 202,
                column: "Day",
                value: new DateTime(2021, 7, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 203,
                column: "Day",
                value: new DateTime(2021, 7, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 204,
                column: "Day",
                value: new DateTime(2021, 7, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 205,
                column: "Day",
                value: new DateTime(2021, 7, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 206,
                column: "Day",
                value: new DateTime(2021, 7, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 207,
                column: "Day",
                value: new DateTime(2021, 7, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 209,
                column: "Day",
                value: new DateTime(2021, 8, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 210,
                column: "Day",
                value: new DateTime(2021, 8, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 211,
                column: "Day",
                value: new DateTime(2021, 8, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 212,
                column: "Day",
                value: new DateTime(2021, 8, 4, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 213,
                column: "Day",
                value: new DateTime(2021, 8, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 214,
                column: "Day",
                value: new DateTime(2021, 8, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 216,
                column: "Day",
                value: new DateTime(2021, 8, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 217,
                column: "Day",
                value: new DateTime(2021, 8, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 218,
                column: "Day",
                value: new DateTime(2021, 8, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 219,
                column: "Day",
                value: new DateTime(2021, 8, 11, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 220,
                column: "Day",
                value: new DateTime(2021, 8, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 221,
                column: "Day",
                value: new DateTime(2021, 8, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 223,
                column: "Day",
                value: new DateTime(2021, 8, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 224,
                column: "Day",
                value: new DateTime(2021, 8, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 225,
                column: "Day",
                value: new DateTime(2021, 8, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 226,
                column: "Day",
                value: new DateTime(2021, 8, 18, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 227,
                column: "Day",
                value: new DateTime(2021, 8, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 228,
                column: "Day",
                value: new DateTime(2021, 8, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 230,
                column: "Day",
                value: new DateTime(2021, 8, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 231,
                column: "Day",
                value: new DateTime(2021, 8, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 232,
                column: "Day",
                value: new DateTime(2021, 8, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 233,
                column: "Day",
                value: new DateTime(2021, 8, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 234,
                column: "Day",
                value: new DateTime(2021, 8, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 235,
                column: "Day",
                value: new DateTime(2021, 8, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 237,
                column: "Day",
                value: new DateTime(2021, 8, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 238,
                column: "Day",
                value: new DateTime(2021, 8, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 239,
                column: "Day",
                value: new DateTime(2021, 8, 31, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 240,
                column: "Day",
                value: new DateTime(2021, 9, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 241,
                column: "Day",
                value: new DateTime(2021, 9, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 242,
                column: "Day",
                value: new DateTime(2021, 9, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 244,
                column: "Day",
                value: new DateTime(2021, 9, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 245,
                column: "Day",
                value: new DateTime(2021, 9, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 246,
                column: "Day",
                value: new DateTime(2021, 9, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 247,
                column: "Day",
                value: new DateTime(2021, 9, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 248,
                column: "Day",
                value: new DateTime(2021, 9, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 249,
                column: "Day",
                value: new DateTime(2021, 9, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 251,
                column: "Day",
                value: new DateTime(2021, 9, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 252,
                column: "Day",
                value: new DateTime(2021, 9, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 253,
                column: "Day",
                value: new DateTime(2021, 9, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 254,
                column: "Day",
                value: new DateTime(2021, 9, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 255,
                column: "Day",
                value: new DateTime(2021, 9, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 256,
                column: "Day",
                value: new DateTime(2021, 9, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 258,
                column: "Day",
                value: new DateTime(2021, 9, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 259,
                column: "Day",
                value: new DateTime(2021, 9, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 260,
                column: "Day",
                value: new DateTime(2021, 9, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 261,
                column: "Day",
                value: new DateTime(2021, 9, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 262,
                column: "Day",
                value: new DateTime(2021, 9, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 263,
                column: "Day",
                value: new DateTime(2021, 9, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 265,
                column: "Day",
                value: new DateTime(2021, 9, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 266,
                column: "Day",
                value: new DateTime(2021, 9, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 267,
                column: "Day",
                value: new DateTime(2021, 9, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 268,
                column: "Day",
                value: new DateTime(2021, 9, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 269,
                column: "Day",
                value: new DateTime(2021, 9, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 270,
                column: "Day",
                value: new DateTime(2021, 10, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 272,
                column: "Day",
                value: new DateTime(2021, 10, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 273,
                column: "Day",
                value: new DateTime(2021, 10, 4, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 274,
                column: "Day",
                value: new DateTime(2021, 10, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 275,
                column: "Day",
                value: new DateTime(2021, 10, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 276,
                column: "Day",
                value: new DateTime(2021, 10, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 277,
                column: "Day",
                value: new DateTime(2021, 10, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 279,
                column: "Day",
                value: new DateTime(2021, 10, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 280,
                column: "Day",
                value: new DateTime(2021, 10, 11, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 281,
                column: "Day",
                value: new DateTime(2021, 10, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 282,
                column: "Day",
                value: new DateTime(2021, 10, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 283,
                column: "Day",
                value: new DateTime(2021, 10, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 284,
                column: "Day",
                value: new DateTime(2021, 10, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 286,
                column: "Day",
                value: new DateTime(2021, 10, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 287,
                column: "Day",
                value: new DateTime(2021, 10, 18, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 288,
                column: "Day",
                value: new DateTime(2021, 10, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 289,
                column: "Day",
                value: new DateTime(2021, 10, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 290,
                column: "Day",
                value: new DateTime(2021, 10, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 291,
                column: "Day",
                value: new DateTime(2021, 10, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 293,
                column: "Day",
                value: new DateTime(2021, 10, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 294,
                column: "Day",
                value: new DateTime(2021, 10, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 295,
                column: "Day",
                value: new DateTime(2021, 10, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 296,
                column: "Day",
                value: new DateTime(2021, 10, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 297,
                column: "Day",
                value: new DateTime(2021, 10, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 298,
                column: "Day",
                value: new DateTime(2021, 10, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class dataset2 : Migration
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
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 7, 21, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 183, 2, new DateTime(2021, 10, 12, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 185, 2, new DateTime(2021, 10, 14, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 186, 2, new DateTime(2021, 10, 15, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 187, 2, new DateTime(2021, 10, 16, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 188, 2, new DateTime(2021, 10, 17, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 189, 2, new DateTime(2021, 10, 18, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 190, 2, new DateTime(2021, 10, 19, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 192, 2, new DateTime(2021, 10, 21, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 193, 2, new DateTime(2021, 10, 22, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 194, 2, new DateTime(2021, 10, 23, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 195, 2, new DateTime(2021, 10, 24, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 196, 2, new DateTime(2021, 10, 25, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 197, 2, new DateTime(2021, 10, 26, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 199, 2, new DateTime(2021, 10, 28, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 182, 2, new DateTime(2021, 10, 11, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 200, 3, new DateTime(2021, 7, 21, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 202, 3, new DateTime(2021, 7, 23, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 204, 3, new DateTime(2021, 7, 25, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 205, 3, new DateTime(2021, 7, 26, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 206, 3, new DateTime(2021, 7, 27, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 207, 3, new DateTime(2021, 7, 28, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 208, 3, new DateTime(2021, 7, 29, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 209, 3, new DateTime(2021, 7, 30, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 211, 3, new DateTime(2021, 8, 1, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 212, 3, new DateTime(2021, 8, 2, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 213, 3, new DateTime(2021, 8, 3, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 214, 3, new DateTime(2021, 8, 4, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 215, 3, new DateTime(2021, 8, 5, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 216, 3, new DateTime(2021, 8, 6, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 218, 3, new DateTime(2021, 8, 8, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 201, 3, new DateTime(2021, 7, 22, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 181, 2, new DateTime(2021, 10, 10, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 180, 2, new DateTime(2021, 10, 9, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 179, 2, new DateTime(2021, 10, 8, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 141, 2, new DateTime(2021, 8, 31, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 143, 2, new DateTime(2021, 9, 2, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 144, 2, new DateTime(2021, 9, 3, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 145, 2, new DateTime(2021, 9, 4, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 146, 2, new DateTime(2021, 9, 5, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 148, 2, new DateTime(2021, 9, 7, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 150, 2, new DateTime(2021, 9, 9, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 151, 2, new DateTime(2021, 9, 10, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 152, 2, new DateTime(2021, 9, 11, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 153, 2, new DateTime(2021, 9, 12, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 154, 2, new DateTime(2021, 9, 13, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 155, 2, new DateTime(2021, 9, 14, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 157, 2, new DateTime(2021, 9, 16, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 158, 2, new DateTime(2021, 9, 17, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 159, 2, new DateTime(2021, 9, 18, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 160, 2, new DateTime(2021, 9, 19, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 161, 2, new DateTime(2021, 9, 20, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 178, 2, new DateTime(2021, 10, 7, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 176, 2, new DateTime(2021, 10, 5, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 175, 2, new DateTime(2021, 10, 4, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 174, 2, new DateTime(2021, 10, 3, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 173, 2, new DateTime(2021, 10, 2, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 172, 2, new DateTime(2021, 10, 1, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 219, 3, new DateTime(2021, 8, 9, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 171, 2, new DateTime(2021, 9, 30, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 168, 2, new DateTime(2021, 9, 27, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 167, 2, new DateTime(2021, 9, 26, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 166, 2, new DateTime(2021, 9, 25, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 165, 2, new DateTime(2021, 9, 24, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 164, 2, new DateTime(2021, 9, 23, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 162, 2, new DateTime(2021, 9, 21, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 169, 2, new DateTime(2021, 9, 28, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 220, 3, new DateTime(2021, 8, 10, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 221, 3, new DateTime(2021, 8, 11, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 222, 3, new DateTime(2021, 8, 12, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 264, 3, new DateTime(2021, 9, 23, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 265, 3, new DateTime(2021, 9, 24, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 267, 3, new DateTime(2021, 9, 26, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 268, 3, new DateTime(2021, 9, 27, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 269, 3, new DateTime(2021, 9, 28, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 270, 3, new DateTime(2021, 9, 29, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 271, 3, new DateTime(2021, 9, 30, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 272, 3, new DateTime(2021, 10, 1, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 274, 3, new DateTime(2021, 10, 3, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 275, 3, new DateTime(2021, 10, 4, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 276, 3, new DateTime(2021, 10, 5, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 277, 3, new DateTime(2021, 10, 6, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 278, 3, new DateTime(2021, 10, 7, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 279, 3, new DateTime(2021, 10, 8, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 281, 3, new DateTime(2021, 10, 10, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 282, 3, new DateTime(2021, 10, 11, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 283, 3, new DateTime(2021, 10, 12, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 299, 3, new DateTime(2021, 10, 28, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 298, 3, new DateTime(2021, 10, 27, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 297, 3, new DateTime(2021, 10, 26, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 296, 3, new DateTime(2021, 10, 25, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 295, 3, new DateTime(2021, 10, 24, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 293, 3, new DateTime(2021, 10, 22, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 263, 3, new DateTime(2021, 9, 22, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 292, 3, new DateTime(2021, 10, 21, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 290, 3, new DateTime(2021, 10, 19, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 289, 3, new DateTime(2021, 10, 18, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 288, 3, new DateTime(2021, 10, 17, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 286, 3, new DateTime(2021, 10, 15, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 285, 3, new DateTime(2021, 10, 14, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 284, 3, new DateTime(2021, 10, 13, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 291, 3, new DateTime(2021, 10, 20, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 140, 2, new DateTime(2021, 8, 30, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 262, 3, new DateTime(2021, 9, 21, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 260, 3, new DateTime(2021, 9, 19, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 223, 3, new DateTime(2021, 8, 13, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 225, 3, new DateTime(2021, 8, 15, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 226, 3, new DateTime(2021, 8, 16, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 227, 3, new DateTime(2021, 8, 17, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 228, 3, new DateTime(2021, 8, 18, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 229, 3, new DateTime(2021, 8, 19, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 230, 3, new DateTime(2021, 8, 20, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 232, 3, new DateTime(2021, 8, 22, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 233, 3, new DateTime(2021, 8, 23, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 234, 3, new DateTime(2021, 8, 24, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 235, 3, new DateTime(2021, 8, 25, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 236, 3, new DateTime(2021, 8, 26, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 237, 3, new DateTime(2021, 8, 27, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 239, 3, new DateTime(2021, 8, 29, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 240, 3, new DateTime(2021, 8, 30, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 241, 3, new DateTime(2021, 8, 31, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 242, 3, new DateTime(2021, 9, 1, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 258, 3, new DateTime(2021, 9, 17, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 257, 3, new DateTime(2021, 9, 16, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 256, 3, new DateTime(2021, 9, 15, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 255, 3, new DateTime(2021, 9, 14, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 254, 3, new DateTime(2021, 9, 13, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 253, 3, new DateTime(2021, 9, 12, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 261, 3, new DateTime(2021, 9, 20, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 251, 3, new DateTime(2021, 9, 10, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 249, 3, new DateTime(2021, 9, 8, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 248, 3, new DateTime(2021, 9, 7, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 247, 3, new DateTime(2021, 9, 6, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 246, 3, new DateTime(2021, 9, 5, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 244, 3, new DateTime(2021, 9, 3, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 243, 3, new DateTime(2021, 9, 2, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 250, 3, new DateTime(2021, 9, 9, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2221) },
                    { 139, 2, new DateTime(2021, 8, 29, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 147, 2, new DateTime(2021, 9, 6, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 137, 2, new DateTime(2021, 8, 27, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 52, 1, new DateTime(2021, 9, 10, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 51, 1, new DateTime(2021, 9, 9, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 50, 1, new DateTime(2021, 9, 8, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 49, 1, new DateTime(2021, 9, 7, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 48, 1, new DateTime(2021, 9, 6, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 47, 1, new DateTime(2021, 9, 5, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 53, 1, new DateTime(2021, 9, 11, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 46, 1, new DateTime(2021, 9, 4, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 44, 1, new DateTime(2021, 9, 2, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 43, 1, new DateTime(2021, 9, 1, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 42, 1, new DateTime(2021, 8, 31, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 41, 1, new DateTime(2021, 8, 30, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 40, 1, new DateTime(2021, 8, 29, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 39, 1, new DateTime(2021, 8, 28, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 45, 1, new DateTime(2021, 9, 3, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 38, 1, new DateTime(2021, 8, 27, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 54, 1, new DateTime(2021, 9, 12, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 56, 1, new DateTime(2021, 9, 14, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 70, 1, new DateTime(2021, 9, 28, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 69, 1, new DateTime(2021, 9, 27, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 138, 2, new DateTime(2021, 8, 28, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 67, 1, new DateTime(2021, 9, 25, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 66, 1, new DateTime(2021, 9, 24, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 65, 1, new DateTime(2021, 9, 23, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 55, 1, new DateTime(2021, 9, 13, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 64, 1, new DateTime(2021, 9, 22, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 62, 1, new DateTime(2021, 9, 20, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 61, 1, new DateTime(2021, 9, 19, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 60, 1, new DateTime(2021, 9, 18, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 59, 1, new DateTime(2021, 9, 17, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 58, 1, new DateTime(2021, 9, 16, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 57, 1, new DateTime(2021, 9, 15, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 63, 1, new DateTime(2021, 9, 21, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 37, 1, new DateTime(2021, 8, 26, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 36, 1, new DateTime(2021, 8, 25, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 35, 1, new DateTime(2021, 8, 24, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 15, 1, new DateTime(2021, 8, 4, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 14, 1, new DateTime(2021, 8, 3, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 13, 1, new DateTime(2021, 8, 2, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 12, 1, new DateTime(2021, 8, 1, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 11, 1, new DateTime(2021, 7, 31, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 10, 1, new DateTime(2021, 7, 30, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 16, 1, new DateTime(2021, 8, 5, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 9, 1, new DateTime(2021, 7, 29, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 7, 1, new DateTime(2021, 7, 27, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 6, 1, new DateTime(2021, 7, 26, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 5, 1, new DateTime(2021, 7, 25, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 4, 1, new DateTime(2021, 7, 24, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 3, 1, new DateTime(2021, 7, 23, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 2, 1, new DateTime(2021, 7, 22, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 8, 1, new DateTime(2021, 7, 28, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 17, 1, new DateTime(2021, 8, 6, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 18, 1, new DateTime(2021, 8, 7, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 19, 1, new DateTime(2021, 8, 8, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 34, 1, new DateTime(2021, 8, 23, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 33, 1, new DateTime(2021, 8, 22, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 32, 1, new DateTime(2021, 8, 21, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 31, 1, new DateTime(2021, 8, 20, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 30, 1, new DateTime(2021, 8, 19, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 29, 1, new DateTime(2021, 8, 18, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 28, 1, new DateTime(2021, 8, 17, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 27, 1, new DateTime(2021, 8, 16, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 26, 1, new DateTime(2021, 8, 15, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 25, 1, new DateTime(2021, 8, 14, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 24, 1, new DateTime(2021, 8, 13, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 23, 1, new DateTime(2021, 8, 12, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 22, 1, new DateTime(2021, 8, 11, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 21, 1, new DateTime(2021, 8, 10, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 20, 1, new DateTime(2021, 8, 9, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 71, 1, new DateTime(2021, 9, 29, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 72, 1, new DateTime(2021, 9, 30, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 68, 1, new DateTime(2021, 9, 26, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 74, 1, new DateTime(2021, 10, 2, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 103, 2, new DateTime(2021, 7, 24, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 104, 2, new DateTime(2021, 7, 25, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 105, 2, new DateTime(2021, 7, 26, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 106, 2, new DateTime(2021, 7, 27, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 108, 2, new DateTime(2021, 7, 29, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 109, 2, new DateTime(2021, 7, 30, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 110, 2, new DateTime(2021, 7, 31, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 111, 2, new DateTime(2021, 8, 1, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 112, 2, new DateTime(2021, 8, 2, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 113, 2, new DateTime(2021, 8, 3, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 115, 2, new DateTime(2021, 8, 5, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 116, 2, new DateTime(2021, 8, 6, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 117, 2, new DateTime(2021, 8, 7, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 118, 2, new DateTime(2021, 8, 8, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 119, 2, new DateTime(2021, 8, 9, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 120, 2, new DateTime(2021, 8, 10, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 122, 2, new DateTime(2021, 8, 12, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 123, 2, new DateTime(2021, 8, 13, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 124, 2, new DateTime(2021, 8, 14, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 125, 2, new DateTime(2021, 8, 15, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 126, 2, new DateTime(2021, 8, 16, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 127, 2, new DateTime(2021, 8, 17, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 129, 2, new DateTime(2021, 8, 19, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 130, 2, new DateTime(2021, 8, 20, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 131, 2, new DateTime(2021, 8, 21, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 132, 2, new DateTime(2021, 8, 22, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 133, 2, new DateTime(2021, 8, 23, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 134, 2, new DateTime(2021, 8, 24, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 136, 2, new DateTime(2021, 8, 26, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 73, 1, new DateTime(2021, 10, 1, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 101, 2, new DateTime(2021, 7, 22, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 102, 2, new DateTime(2021, 7, 23, 12, 17, 51, 778, DateTimeKind.Local).AddTicks(2077) },
                    { 87, 1, new DateTime(2021, 10, 15, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 84, 1, new DateTime(2021, 10, 12, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 85, 1, new DateTime(2021, 10, 13, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 86, 1, new DateTime(2021, 10, 14, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 81, 1, new DateTime(2021, 10, 9, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 80, 1, new DateTime(2021, 10, 8, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 79, 1, new DateTime(2021, 10, 7, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 78, 1, new DateTime(2021, 10, 6, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 77, 1, new DateTime(2021, 10, 5, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 76, 1, new DateTime(2021, 10, 4, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 75, 1, new DateTime(2021, 10, 3, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 88, 1, new DateTime(2021, 10, 16, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 89, 1, new DateTime(2021, 10, 17, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 90, 1, new DateTime(2021, 10, 18, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 91, 1, new DateTime(2021, 10, 19, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 92, 1, new DateTime(2021, 10, 20, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 93, 1, new DateTime(2021, 10, 21, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 94, 1, new DateTime(2021, 10, 22, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 95, 1, new DateTime(2021, 10, 23, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 96, 1, new DateTime(2021, 10, 24, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 97, 1, new DateTime(2021, 10, 25, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 98, 1, new DateTime(2021, 10, 26, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 99, 1, new DateTime(2021, 10, 27, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 83, 1, new DateTime(2021, 10, 11, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) },
                    { 82, 1, new DateTime(2021, 10, 10, 12, 17, 51, 775, DateTimeKind.Local).AddTicks(5882) }
                });

            migrationBuilder.InsertData(
                table: "HeureOuverture",
                columns: new[] { "Id", "CentreId", "HeureDebut", "HeureFin", "Jour" },
                values: new object[,]
                {
                    { 14, 3, 8, 20, 1 },
                    { 15, 3, 8, 20, 2 },
                    { 16, 3, 8, 20, 3 },
                    { 17, 3, 8, 20, 4 },
                    { 18, 3, 8, 22, 5 },
                    { 2, 1, 8, 20, 2 },
                    { 6, 1, 8, 20, 6 },
                    { 13, 2, 7, 18, 7 },
                    { 12, 2, 7, 18, 6 },
                    { 11, 2, 7, 18, 5 },
                    { 10, 2, 7, 18, 4 },
                    { 9, 2, 7, 18, 2 },
                    { 8, 2, 7, 18, 1 },
                    { 7, 1, 8, 22, 7 },
                    { 1, 1, 8, 20, 1 },
                    { 5, 1, 8, 20, 5 },
                    { 4, 1, 8, 20, 4 },
                    { 3, 1, 8, 20, 3 }
                });

            migrationBuilder.InsertData(
                table: "LotVaccin",
                columns: new[] { "Id", "CentreId", "DateEntree", "DateSortie", "FournisseurId", "QuantiteEntree", "QuantiteRestante", "TypeVaccinId" },
                values: new object[,]
                {
                    { 6, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 50, 50, 2 },
                    { 2, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 40, 40, 2 },
                    { 3, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 60, 60, 3 },
                    { 1, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 20, 20, 1 },
                    { 5, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 30, 30, 1 },
                    { 4, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 10, 10, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 299);

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
        }
    }
}

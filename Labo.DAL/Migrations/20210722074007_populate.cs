using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class populate : Migration
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
                    { 1, 1, new DateTime(2021, 7, 23, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 183, 2, new DateTime(2021, 10, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 184, 2, new DateTime(2021, 10, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 185, 2, new DateTime(2021, 10, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 186, 2, new DateTime(2021, 10, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 187, 2, new DateTime(2021, 10, 18, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 188, 2, new DateTime(2021, 10, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 190, 2, new DateTime(2021, 10, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 191, 2, new DateTime(2021, 10, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 192, 2, new DateTime(2021, 10, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 193, 2, new DateTime(2021, 10, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 194, 2, new DateTime(2021, 10, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 195, 2, new DateTime(2021, 10, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 197, 2, new DateTime(2021, 10, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 198, 2, new DateTime(2021, 10, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 181, 2, new DateTime(2021, 10, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 199, 2, new DateTime(2021, 10, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 202, 3, new DateTime(2021, 7, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 203, 3, new DateTime(2021, 7, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 204, 3, new DateTime(2021, 7, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 205, 3, new DateTime(2021, 7, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 206, 3, new DateTime(2021, 7, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 207, 3, new DateTime(2021, 7, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 209, 3, new DateTime(2021, 8, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 210, 3, new DateTime(2021, 8, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 211, 3, new DateTime(2021, 8, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 212, 3, new DateTime(2021, 8, 4, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 213, 3, new DateTime(2021, 8, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 214, 3, new DateTime(2021, 8, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 216, 3, new DateTime(2021, 8, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 217, 3, new DateTime(2021, 8, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 200, 3, new DateTime(2021, 7, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 180, 2, new DateTime(2021, 10, 11, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 179, 2, new DateTime(2021, 10, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 178, 2, new DateTime(2021, 10, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 141, 2, new DateTime(2021, 9, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 142, 2, new DateTime(2021, 9, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 143, 2, new DateTime(2021, 9, 4, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 144, 2, new DateTime(2021, 9, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 145, 2, new DateTime(2021, 9, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 148, 2, new DateTime(2021, 9, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 149, 2, new DateTime(2021, 9, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 150, 2, new DateTime(2021, 9, 11, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 151, 2, new DateTime(2021, 9, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 152, 2, new DateTime(2021, 9, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 153, 2, new DateTime(2021, 9, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 155, 2, new DateTime(2021, 9, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 156, 2, new DateTime(2021, 9, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 157, 2, new DateTime(2021, 9, 18, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 158, 2, new DateTime(2021, 9, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 159, 2, new DateTime(2021, 9, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 160, 2, new DateTime(2021, 9, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 177, 2, new DateTime(2021, 10, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 176, 2, new DateTime(2021, 10, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 174, 2, new DateTime(2021, 10, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 173, 2, new DateTime(2021, 10, 4, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 172, 2, new DateTime(2021, 10, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 171, 2, new DateTime(2021, 10, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 218, 3, new DateTime(2021, 8, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 170, 2, new DateTime(2021, 10, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 167, 2, new DateTime(2021, 9, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 166, 2, new DateTime(2021, 9, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 165, 2, new DateTime(2021, 9, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 164, 2, new DateTime(2021, 9, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 163, 2, new DateTime(2021, 9, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 162, 2, new DateTime(2021, 9, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 169, 2, new DateTime(2021, 9, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 219, 3, new DateTime(2021, 8, 11, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 220, 3, new DateTime(2021, 8, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 221, 3, new DateTime(2021, 8, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 263, 3, new DateTime(2021, 9, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 265, 3, new DateTime(2021, 9, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 266, 3, new DateTime(2021, 9, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 267, 3, new DateTime(2021, 9, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 268, 3, new DateTime(2021, 9, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 269, 3, new DateTime(2021, 9, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 270, 3, new DateTime(2021, 10, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 272, 3, new DateTime(2021, 10, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 273, 3, new DateTime(2021, 10, 4, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 274, 3, new DateTime(2021, 10, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 275, 3, new DateTime(2021, 10, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 276, 3, new DateTime(2021, 10, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 277, 3, new DateTime(2021, 10, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 279, 3, new DateTime(2021, 10, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 280, 3, new DateTime(2021, 10, 11, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 281, 3, new DateTime(2021, 10, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 282, 3, new DateTime(2021, 10, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 298, 3, new DateTime(2021, 10, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 297, 3, new DateTime(2021, 10, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 296, 3, new DateTime(2021, 10, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 295, 3, new DateTime(2021, 10, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 294, 3, new DateTime(2021, 10, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 293, 3, new DateTime(2021, 10, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 262, 3, new DateTime(2021, 9, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 291, 3, new DateTime(2021, 10, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 289, 3, new DateTime(2021, 10, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 288, 3, new DateTime(2021, 10, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 287, 3, new DateTime(2021, 10, 18, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 286, 3, new DateTime(2021, 10, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 284, 3, new DateTime(2021, 10, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 283, 3, new DateTime(2021, 10, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 290, 3, new DateTime(2021, 10, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 139, 2, new DateTime(2021, 8, 31, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 261, 3, new DateTime(2021, 9, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 259, 3, new DateTime(2021, 9, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 223, 3, new DateTime(2021, 8, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 224, 3, new DateTime(2021, 8, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 225, 3, new DateTime(2021, 8, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 226, 3, new DateTime(2021, 8, 18, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 227, 3, new DateTime(2021, 8, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 228, 3, new DateTime(2021, 8, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 230, 3, new DateTime(2021, 8, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 231, 3, new DateTime(2021, 8, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 232, 3, new DateTime(2021, 8, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 233, 3, new DateTime(2021, 8, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 234, 3, new DateTime(2021, 8, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 235, 3, new DateTime(2021, 8, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 237, 3, new DateTime(2021, 8, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 238, 3, new DateTime(2021, 8, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 239, 3, new DateTime(2021, 8, 31, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 240, 3, new DateTime(2021, 9, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 241, 3, new DateTime(2021, 9, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 258, 3, new DateTime(2021, 9, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 256, 3, new DateTime(2021, 9, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 255, 3, new DateTime(2021, 9, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 254, 3, new DateTime(2021, 9, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 253, 3, new DateTime(2021, 9, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 252, 3, new DateTime(2021, 9, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 260, 3, new DateTime(2021, 9, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 251, 3, new DateTime(2021, 9, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 248, 3, new DateTime(2021, 9, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 247, 3, new DateTime(2021, 9, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 246, 3, new DateTime(2021, 9, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 245, 3, new DateTime(2021, 9, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 244, 3, new DateTime(2021, 9, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 242, 3, new DateTime(2021, 9, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 249, 3, new DateTime(2021, 9, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2260) },
                    { 138, 2, new DateTime(2021, 8, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 146, 2, new DateTime(2021, 9, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 136, 2, new DateTime(2021, 8, 28, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 52, 1, new DateTime(2021, 9, 12, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 51, 1, new DateTime(2021, 9, 11, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 50, 1, new DateTime(2021, 9, 10, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 49, 1, new DateTime(2021, 9, 9, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 48, 1, new DateTime(2021, 9, 8, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 47, 1, new DateTime(2021, 9, 7, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 53, 1, new DateTime(2021, 9, 13, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 46, 1, new DateTime(2021, 9, 6, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 44, 1, new DateTime(2021, 9, 4, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 43, 1, new DateTime(2021, 9, 3, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 42, 1, new DateTime(2021, 9, 2, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 41, 1, new DateTime(2021, 9, 1, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 40, 1, new DateTime(2021, 8, 31, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 39, 1, new DateTime(2021, 8, 30, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 45, 1, new DateTime(2021, 9, 5, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 38, 1, new DateTime(2021, 8, 29, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 54, 1, new DateTime(2021, 9, 14, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 56, 1, new DateTime(2021, 9, 16, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 70, 1, new DateTime(2021, 9, 30, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 69, 1, new DateTime(2021, 9, 29, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 137, 2, new DateTime(2021, 8, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 67, 1, new DateTime(2021, 9, 27, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 66, 1, new DateTime(2021, 9, 26, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 65, 1, new DateTime(2021, 9, 25, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 55, 1, new DateTime(2021, 9, 15, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 64, 1, new DateTime(2021, 9, 24, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 62, 1, new DateTime(2021, 9, 22, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 61, 1, new DateTime(2021, 9, 21, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 60, 1, new DateTime(2021, 9, 20, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 59, 1, new DateTime(2021, 9, 19, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 58, 1, new DateTime(2021, 9, 18, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 57, 1, new DateTime(2021, 9, 17, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 63, 1, new DateTime(2021, 9, 23, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 37, 1, new DateTime(2021, 8, 28, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 36, 1, new DateTime(2021, 8, 27, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 35, 1, new DateTime(2021, 8, 26, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 15, 1, new DateTime(2021, 8, 6, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 14, 1, new DateTime(2021, 8, 5, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 13, 1, new DateTime(2021, 8, 4, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 12, 1, new DateTime(2021, 8, 3, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 11, 1, new DateTime(2021, 8, 2, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 10, 1, new DateTime(2021, 8, 1, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 16, 1, new DateTime(2021, 8, 7, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 9, 1, new DateTime(2021, 7, 31, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 7, 1, new DateTime(2021, 7, 29, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 6, 1, new DateTime(2021, 7, 28, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 5, 1, new DateTime(2021, 7, 27, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 4, 1, new DateTime(2021, 7, 26, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 3, 1, new DateTime(2021, 7, 25, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 2, 1, new DateTime(2021, 7, 24, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 8, 1, new DateTime(2021, 7, 30, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 17, 1, new DateTime(2021, 8, 8, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 18, 1, new DateTime(2021, 8, 9, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 19, 1, new DateTime(2021, 8, 10, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 34, 1, new DateTime(2021, 8, 25, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 33, 1, new DateTime(2021, 8, 24, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 32, 1, new DateTime(2021, 8, 23, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 31, 1, new DateTime(2021, 8, 22, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 30, 1, new DateTime(2021, 8, 21, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 29, 1, new DateTime(2021, 8, 20, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 28, 1, new DateTime(2021, 8, 19, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 27, 1, new DateTime(2021, 8, 18, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 26, 1, new DateTime(2021, 8, 17, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 25, 1, new DateTime(2021, 8, 16, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 24, 1, new DateTime(2021, 8, 15, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 23, 1, new DateTime(2021, 8, 14, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 22, 1, new DateTime(2021, 8, 13, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 21, 1, new DateTime(2021, 8, 12, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 20, 1, new DateTime(2021, 8, 11, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 71, 1, new DateTime(2021, 10, 1, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 72, 1, new DateTime(2021, 10, 2, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 68, 1, new DateTime(2021, 9, 28, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 74, 1, new DateTime(2021, 10, 4, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 102, 2, new DateTime(2021, 7, 25, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 103, 2, new DateTime(2021, 7, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 104, 2, new DateTime(2021, 7, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 106, 2, new DateTime(2021, 7, 29, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 107, 2, new DateTime(2021, 7, 30, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 108, 2, new DateTime(2021, 7, 31, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 109, 2, new DateTime(2021, 8, 1, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 110, 2, new DateTime(2021, 8, 2, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 111, 2, new DateTime(2021, 8, 3, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 113, 2, new DateTime(2021, 8, 5, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 114, 2, new DateTime(2021, 8, 6, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 115, 2, new DateTime(2021, 8, 7, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 116, 2, new DateTime(2021, 8, 8, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 117, 2, new DateTime(2021, 8, 9, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 118, 2, new DateTime(2021, 8, 10, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 120, 2, new DateTime(2021, 8, 12, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 121, 2, new DateTime(2021, 8, 13, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 122, 2, new DateTime(2021, 8, 14, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 123, 2, new DateTime(2021, 8, 15, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 124, 2, new DateTime(2021, 8, 16, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 125, 2, new DateTime(2021, 8, 17, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 127, 2, new DateTime(2021, 8, 19, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 128, 2, new DateTime(2021, 8, 20, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 129, 2, new DateTime(2021, 8, 21, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 130, 2, new DateTime(2021, 8, 22, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 131, 2, new DateTime(2021, 8, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 132, 2, new DateTime(2021, 8, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 134, 2, new DateTime(2021, 8, 26, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 135, 2, new DateTime(2021, 8, 27, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 73, 1, new DateTime(2021, 10, 3, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 100, 2, new DateTime(2021, 7, 23, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 101, 2, new DateTime(2021, 7, 24, 9, 40, 6, 434, DateTimeKind.Local).AddTicks(2123) },
                    { 90, 1, new DateTime(2021, 10, 20, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 83, 1, new DateTime(2021, 10, 13, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 84, 1, new DateTime(2021, 10, 14, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 85, 1, new DateTime(2021, 10, 15, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 86, 1, new DateTime(2021, 10, 16, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 80, 1, new DateTime(2021, 10, 10, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 79, 1, new DateTime(2021, 10, 9, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 78, 1, new DateTime(2021, 10, 8, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 77, 1, new DateTime(2021, 10, 7, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 76, 1, new DateTime(2021, 10, 6, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 75, 1, new DateTime(2021, 10, 5, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 87, 1, new DateTime(2021, 10, 17, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 88, 1, new DateTime(2021, 10, 18, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 89, 1, new DateTime(2021, 10, 19, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 82, 1, new DateTime(2021, 10, 12, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 81, 1, new DateTime(2021, 10, 11, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 92, 1, new DateTime(2021, 10, 22, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 93, 1, new DateTime(2021, 10, 23, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 94, 1, new DateTime(2021, 10, 24, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 95, 1, new DateTime(2021, 10, 25, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 96, 1, new DateTime(2021, 10, 26, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 97, 1, new DateTime(2021, 10, 27, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 98, 1, new DateTime(2021, 10, 28, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 99, 1, new DateTime(2021, 10, 29, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) },
                    { 91, 1, new DateTime(2021, 10, 21, 9, 40, 6, 431, DateTimeKind.Local).AddTicks(8542) }
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
                    { 13, 2, 7, 18, 7 },
                    { 1, 1, 8, 20, 1 },
                    { 3, 1, 8, 20, 3 },
                    { 4, 1, 8, 20, 4 },
                    { 6, 1, 8, 20, 6 },
                    { 7, 1, 8, 22, 7 },
                    { 5, 1, 8, 20, 5 },
                    { 9, 2, 7, 18, 2 },
                    { 10, 2, 7, 18, 4 },
                    { 11, 2, 7, 18, 5 },
                    { 12, 2, 7, 18, 6 },
                    { 8, 2, 7, 18, 1 }
                });

            migrationBuilder.InsertData(
                table: "LotVaccin",
                columns: new[] { "Id", "CentreId", "DateEntree", "DateSortie", "FournisseurId", "QuantiteEntree", "QuantiteRestante", "TypeVaccinId" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 60, 60, 3 },
                    { 1, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 20, 20, 1 },
                    { 5, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 30, 30, 1 },
                    { 2, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 40, 40, 2 },
                    { 6, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 50, 50, 2 },
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
                keyValue: 100);

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
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 107);

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
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 114);

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
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 121);

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
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 128);

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
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 135);

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
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 142);

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
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 149);

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
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 156);

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
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 163);

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
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 170);

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
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 177);

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
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 184);

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
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 191);

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
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 198);

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
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 203);

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
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 210);

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
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 217);

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
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 224);

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
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 231);

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
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 238);

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
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 245);

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
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 252);

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
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 259);

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
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 266);

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
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 273);

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
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 280);

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
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 287);

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
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "CalendrierJour",
                keyColumn: "Id",
                keyValue: 294);

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

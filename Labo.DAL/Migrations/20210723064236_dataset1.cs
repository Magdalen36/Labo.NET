using System;
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
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 183, 2, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 184, 2, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 185, 2, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 186, 2, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 187, 2, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 188, 2, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 190, 2, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 191, 2, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 192, 2, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 193, 2, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 194, 2, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 195, 2, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 197, 2, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 198, 2, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 181, 2, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 199, 2, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 202, 3, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 203, 3, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 204, 3, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 205, 3, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 206, 3, new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 207, 3, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 209, 3, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 210, 3, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 211, 3, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 212, 3, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 213, 3, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 214, 3, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 216, 3, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 217, 3, new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 200, 3, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 180, 2, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 179, 2, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 178, 2, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, 2, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, 2, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, 2, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, 2, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, 2, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, 2, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, 2, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 150, 2, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, 2, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 152, 2, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 153, 2, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 155, 2, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 156, 2, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, 2, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 158, 2, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, 2, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 160, 2, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 177, 2, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 176, 2, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 174, 2, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 173, 2, new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 172, 2, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 171, 2, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 218, 3, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 170, 2, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 167, 2, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 166, 2, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 165, 2, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 164, 2, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 163, 2, new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 162, 2, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 169, 2, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 219, 3, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 220, 3, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 221, 3, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 263, 3, new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 265, 3, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 266, 3, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 267, 3, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 268, 3, new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 269, 3, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 270, 3, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 272, 3, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 273, 3, new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 274, 3, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 275, 3, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 276, 3, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 277, 3, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 279, 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 280, 3, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 281, 3, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 282, 3, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 298, 3, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 297, 3, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 296, 3, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 295, 3, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 294, 3, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 293, 3, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 262, 3, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 291, 3, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 289, 3, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 288, 3, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 287, 3, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 286, 3, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 284, 3, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 283, 3, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 290, 3, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, 2, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 261, 3, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 259, 3, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 223, 3, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 224, 3, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 225, 3, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 226, 3, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 227, 3, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 228, 3, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 230, 3, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 231, 3, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 232, 3, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 233, 3, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 234, 3, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 235, 3, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 237, 3, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 238, 3, new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 239, 3, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 240, 3, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 241, 3, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 258, 3, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 256, 3, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 255, 3, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 254, 3, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 253, 3, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 252, 3, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 260, 3, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 251, 3, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 248, 3, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 247, 3, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 246, 3, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 245, 3, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 244, 3, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 242, 3, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 249, 3, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, 2, new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, 2, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, 2, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 1, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 1, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 1, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 1, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 1, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 1, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 1, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 1, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 1, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 1, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 1, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 1, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 1, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 1, new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 1, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 1, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 1, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 1, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 1, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 1, new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, 2, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 1, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 1, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 1, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 1, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 1, new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 1, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 1, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 60, 1, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 1, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 1, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 1, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 1, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 1, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 1, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 1, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 1, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 1, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 1, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 1, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 1, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 1, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 1, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 1, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 1, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 72, 1, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 1, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 1, new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 2, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 2, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 2, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 2, new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 2, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, 2, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 2, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, 2, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 2, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 2, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, 2, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 2, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 2, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 2, new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 2, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 2, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 2, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 2, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 2, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 2, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 2, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 2, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, 2, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 2, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 2, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, 2, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, 2, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, 2, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, 2, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 1, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 2, new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 2, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 1, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 1, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 1, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 1, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 1, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 1, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 1, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 78, 1, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 1, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 1, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 1, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 1, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 1, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 1, new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 1, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 1, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 1, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 1, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 1, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 1, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 1, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 1, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 1, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 1, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 1, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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

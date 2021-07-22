using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class dataset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 7, 23, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 185, 2, new DateTime(2021, 10, 16, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 186, 2, new DateTime(2021, 10, 17, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 187, 2, new DateTime(2021, 10, 18, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 188, 2, new DateTime(2021, 10, 19, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 190, 2, new DateTime(2021, 10, 21, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 191, 2, new DateTime(2021, 10, 22, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 192, 2, new DateTime(2021, 10, 23, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 193, 2, new DateTime(2021, 10, 24, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 194, 2, new DateTime(2021, 10, 25, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 195, 2, new DateTime(2021, 10, 26, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 197, 2, new DateTime(2021, 10, 28, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 198, 2, new DateTime(2021, 10, 29, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 199, 2, new DateTime(2021, 10, 30, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 200, 3, new DateTime(2021, 7, 23, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 184, 2, new DateTime(2021, 10, 15, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 202, 3, new DateTime(2021, 7, 25, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 204, 3, new DateTime(2021, 7, 27, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 205, 3, new DateTime(2021, 7, 28, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 206, 3, new DateTime(2021, 7, 29, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 207, 3, new DateTime(2021, 7, 30, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 209, 3, new DateTime(2021, 8, 1, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 210, 3, new DateTime(2021, 8, 2, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 211, 3, new DateTime(2021, 8, 3, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 212, 3, new DateTime(2021, 8, 4, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 213, 3, new DateTime(2021, 8, 5, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 214, 3, new DateTime(2021, 8, 6, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 216, 3, new DateTime(2021, 8, 8, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 217, 3, new DateTime(2021, 8, 9, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 218, 3, new DateTime(2021, 8, 10, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 219, 3, new DateTime(2021, 8, 11, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 203, 3, new DateTime(2021, 7, 26, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 220, 3, new DateTime(2021, 8, 12, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 183, 2, new DateTime(2021, 10, 14, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 180, 2, new DateTime(2021, 10, 11, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 145, 2, new DateTime(2021, 9, 6, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 146, 2, new DateTime(2021, 9, 7, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 148, 2, new DateTime(2021, 9, 9, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 149, 2, new DateTime(2021, 9, 10, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 150, 2, new DateTime(2021, 9, 11, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 151, 2, new DateTime(2021, 9, 12, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 152, 2, new DateTime(2021, 9, 13, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 153, 2, new DateTime(2021, 9, 14, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 155, 2, new DateTime(2021, 9, 16, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 156, 2, new DateTime(2021, 9, 17, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 157, 2, new DateTime(2021, 9, 18, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 158, 2, new DateTime(2021, 9, 19, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 159, 2, new DateTime(2021, 9, 20, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 160, 2, new DateTime(2021, 9, 21, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 181, 2, new DateTime(2021, 10, 12, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 162, 2, new DateTime(2021, 9, 23, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 164, 2, new DateTime(2021, 9, 25, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 165, 2, new DateTime(2021, 9, 26, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 166, 2, new DateTime(2021, 9, 27, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 167, 2, new DateTime(2021, 9, 28, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 169, 2, new DateTime(2021, 9, 30, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 170, 2, new DateTime(2021, 10, 1, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 171, 2, new DateTime(2021, 10, 2, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 172, 2, new DateTime(2021, 10, 3, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 173, 2, new DateTime(2021, 10, 4, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 174, 2, new DateTime(2021, 10, 5, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 176, 2, new DateTime(2021, 10, 7, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 177, 2, new DateTime(2021, 10, 8, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 178, 2, new DateTime(2021, 10, 9, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 179, 2, new DateTime(2021, 10, 10, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 163, 2, new DateTime(2021, 9, 24, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 143, 2, new DateTime(2021, 9, 4, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 221, 3, new DateTime(2021, 8, 13, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 224, 3, new DateTime(2021, 8, 16, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 265, 3, new DateTime(2021, 9, 26, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 266, 3, new DateTime(2021, 9, 27, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 267, 3, new DateTime(2021, 9, 28, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 268, 3, new DateTime(2021, 9, 29, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 269, 3, new DateTime(2021, 9, 30, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 270, 3, new DateTime(2021, 10, 1, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 272, 3, new DateTime(2021, 10, 3, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 273, 3, new DateTime(2021, 10, 4, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 274, 3, new DateTime(2021, 10, 5, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 275, 3, new DateTime(2021, 10, 6, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 276, 3, new DateTime(2021, 10, 7, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 277, 3, new DateTime(2021, 10, 8, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 279, 3, new DateTime(2021, 10, 10, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 280, 3, new DateTime(2021, 10, 11, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 263, 3, new DateTime(2021, 9, 24, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 281, 3, new DateTime(2021, 10, 12, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 283, 3, new DateTime(2021, 10, 14, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 284, 3, new DateTime(2021, 10, 15, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 286, 3, new DateTime(2021, 10, 17, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 287, 3, new DateTime(2021, 10, 18, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 288, 3, new DateTime(2021, 10, 19, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 289, 3, new DateTime(2021, 10, 20, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 290, 3, new DateTime(2021, 10, 21, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 291, 3, new DateTime(2021, 10, 22, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 293, 3, new DateTime(2021, 10, 24, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 294, 3, new DateTime(2021, 10, 25, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 295, 3, new DateTime(2021, 10, 26, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 296, 3, new DateTime(2021, 10, 27, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 297, 3, new DateTime(2021, 10, 28, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 298, 3, new DateTime(2021, 10, 29, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 282, 3, new DateTime(2021, 10, 13, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 223, 3, new DateTime(2021, 8, 15, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 262, 3, new DateTime(2021, 9, 23, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 260, 3, new DateTime(2021, 9, 21, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 225, 3, new DateTime(2021, 8, 17, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 226, 3, new DateTime(2021, 8, 18, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 227, 3, new DateTime(2021, 8, 19, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 228, 3, new DateTime(2021, 8, 20, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 230, 3, new DateTime(2021, 8, 22, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 231, 3, new DateTime(2021, 8, 23, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 232, 3, new DateTime(2021, 8, 24, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 233, 3, new DateTime(2021, 8, 25, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 234, 3, new DateTime(2021, 8, 26, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 235, 3, new DateTime(2021, 8, 27, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 237, 3, new DateTime(2021, 8, 29, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 238, 3, new DateTime(2021, 8, 30, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 239, 3, new DateTime(2021, 8, 31, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 240, 3, new DateTime(2021, 9, 1, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 261, 3, new DateTime(2021, 9, 22, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 241, 3, new DateTime(2021, 9, 2, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 244, 3, new DateTime(2021, 9, 5, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 245, 3, new DateTime(2021, 9, 6, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 246, 3, new DateTime(2021, 9, 7, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 247, 3, new DateTime(2021, 9, 8, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 248, 3, new DateTime(2021, 9, 9, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 249, 3, new DateTime(2021, 9, 10, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 251, 3, new DateTime(2021, 9, 12, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 252, 3, new DateTime(2021, 9, 13, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 253, 3, new DateTime(2021, 9, 14, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 254, 3, new DateTime(2021, 9, 15, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 255, 3, new DateTime(2021, 9, 16, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 256, 3, new DateTime(2021, 9, 17, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 258, 3, new DateTime(2021, 9, 19, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 259, 3, new DateTime(2021, 9, 20, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 242, 3, new DateTime(2021, 9, 3, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9811) },
                    { 142, 2, new DateTime(2021, 9, 3, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 144, 2, new DateTime(2021, 9, 5, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 139, 2, new DateTime(2021, 8, 31, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 36, 1, new DateTime(2021, 8, 27, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 37, 1, new DateTime(2021, 8, 28, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 38, 1, new DateTime(2021, 8, 29, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 39, 1, new DateTime(2021, 8, 30, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 40, 1, new DateTime(2021, 8, 31, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 41, 1, new DateTime(2021, 9, 1, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 42, 1, new DateTime(2021, 9, 2, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 43, 1, new DateTime(2021, 9, 3, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 44, 1, new DateTime(2021, 9, 4, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 45, 1, new DateTime(2021, 9, 5, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 46, 1, new DateTime(2021, 9, 6, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 47, 1, new DateTime(2021, 9, 7, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 48, 1, new DateTime(2021, 9, 8, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 49, 1, new DateTime(2021, 9, 9, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 35, 1, new DateTime(2021, 8, 26, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 50, 1, new DateTime(2021, 9, 10, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 52, 1, new DateTime(2021, 9, 12, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 53, 1, new DateTime(2021, 9, 13, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 54, 1, new DateTime(2021, 9, 14, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 55, 1, new DateTime(2021, 9, 15, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 56, 1, new DateTime(2021, 9, 16, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 57, 1, new DateTime(2021, 9, 17, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 58, 1, new DateTime(2021, 9, 18, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 59, 1, new DateTime(2021, 9, 19, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 60, 1, new DateTime(2021, 9, 20, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 61, 1, new DateTime(2021, 9, 21, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 62, 1, new DateTime(2021, 9, 22, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 63, 1, new DateTime(2021, 9, 23, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 64, 1, new DateTime(2021, 9, 24, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 65, 1, new DateTime(2021, 9, 25, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 51, 1, new DateTime(2021, 9, 11, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 141, 2, new DateTime(2021, 9, 2, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 34, 1, new DateTime(2021, 8, 25, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 32, 1, new DateTime(2021, 8, 23, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 2, 1, new DateTime(2021, 7, 24, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 3, 1, new DateTime(2021, 7, 25, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 4, 1, new DateTime(2021, 7, 26, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 5, 1, new DateTime(2021, 7, 27, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 6, 1, new DateTime(2021, 7, 28, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 7, 1, new DateTime(2021, 7, 29, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 8, 1, new DateTime(2021, 7, 30, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 9, 1, new DateTime(2021, 7, 31, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 10, 1, new DateTime(2021, 8, 1, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 11, 1, new DateTime(2021, 8, 2, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 12, 1, new DateTime(2021, 8, 3, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 13, 1, new DateTime(2021, 8, 4, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 14, 1, new DateTime(2021, 8, 5, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 15, 1, new DateTime(2021, 8, 6, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 33, 1, new DateTime(2021, 8, 24, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 16, 1, new DateTime(2021, 8, 7, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 18, 1, new DateTime(2021, 8, 9, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 19, 1, new DateTime(2021, 8, 10, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 20, 1, new DateTime(2021, 8, 11, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 21, 1, new DateTime(2021, 8, 12, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 22, 1, new DateTime(2021, 8, 13, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 23, 1, new DateTime(2021, 8, 14, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 24, 1, new DateTime(2021, 8, 15, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 25, 1, new DateTime(2021, 8, 16, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 26, 1, new DateTime(2021, 8, 17, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 27, 1, new DateTime(2021, 8, 18, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 28, 1, new DateTime(2021, 8, 19, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 29, 1, new DateTime(2021, 8, 20, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 30, 1, new DateTime(2021, 8, 21, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 31, 1, new DateTime(2021, 8, 22, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 17, 1, new DateTime(2021, 8, 8, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 67, 1, new DateTime(2021, 9, 27, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 66, 1, new DateTime(2021, 9, 26, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 69, 1, new DateTime(2021, 9, 29, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 68, 1, new DateTime(2021, 9, 28, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 106, 2, new DateTime(2021, 7, 29, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 107, 2, new DateTime(2021, 7, 30, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 108, 2, new DateTime(2021, 7, 31, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 109, 2, new DateTime(2021, 8, 1, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 110, 2, new DateTime(2021, 8, 2, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 111, 2, new DateTime(2021, 8, 3, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 113, 2, new DateTime(2021, 8, 5, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 114, 2, new DateTime(2021, 8, 6, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 115, 2, new DateTime(2021, 8, 7, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 116, 2, new DateTime(2021, 8, 8, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 117, 2, new DateTime(2021, 8, 9, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 118, 2, new DateTime(2021, 8, 10, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 120, 2, new DateTime(2021, 8, 12, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 103, 2, new DateTime(2021, 7, 26, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 121, 2, new DateTime(2021, 8, 13, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 123, 2, new DateTime(2021, 8, 15, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 124, 2, new DateTime(2021, 8, 16, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 125, 2, new DateTime(2021, 8, 17, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 127, 2, new DateTime(2021, 8, 19, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 128, 2, new DateTime(2021, 8, 20, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 129, 2, new DateTime(2021, 8, 21, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 130, 2, new DateTime(2021, 8, 22, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 131, 2, new DateTime(2021, 8, 23, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 132, 2, new DateTime(2021, 8, 24, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 134, 2, new DateTime(2021, 8, 26, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 135, 2, new DateTime(2021, 8, 27, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 136, 2, new DateTime(2021, 8, 28, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 137, 2, new DateTime(2021, 8, 29, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 138, 2, new DateTime(2021, 8, 30, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 122, 2, new DateTime(2021, 8, 14, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 102, 2, new DateTime(2021, 7, 25, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 104, 2, new DateTime(2021, 7, 27, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 100, 2, new DateTime(2021, 7, 23, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) },
                    { 70, 1, new DateTime(2021, 9, 30, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 71, 1, new DateTime(2021, 10, 1, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 72, 1, new DateTime(2021, 10, 2, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 73, 1, new DateTime(2021, 10, 3, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 74, 1, new DateTime(2021, 10, 4, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 75, 1, new DateTime(2021, 10, 5, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 76, 1, new DateTime(2021, 10, 6, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 77, 1, new DateTime(2021, 10, 7, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 78, 1, new DateTime(2021, 10, 8, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 79, 1, new DateTime(2021, 10, 9, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 80, 1, new DateTime(2021, 10, 10, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 81, 1, new DateTime(2021, 10, 11, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 101, 2, new DateTime(2021, 7, 24, 16, 24, 58, 590, DateTimeKind.Local).AddTicks(9672) }
                });

            migrationBuilder.InsertData(
                table: "CalendrierJour",
                columns: new[] { "Id", "CentreId", "Day" },
                values: new object[,]
                {
                    { 83, 1, new DateTime(2021, 10, 13, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 84, 1, new DateTime(2021, 10, 14, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 82, 1, new DateTime(2021, 10, 12, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 86, 1, new DateTime(2021, 10, 16, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 99, 1, new DateTime(2021, 10, 29, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 98, 1, new DateTime(2021, 10, 28, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 97, 1, new DateTime(2021, 10, 27, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 85, 1, new DateTime(2021, 10, 15, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 95, 1, new DateTime(2021, 10, 25, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 94, 1, new DateTime(2021, 10, 24, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 96, 1, new DateTime(2021, 10, 26, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 92, 1, new DateTime(2021, 10, 22, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 91, 1, new DateTime(2021, 10, 21, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 90, 1, new DateTime(2021, 10, 20, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 89, 1, new DateTime(2021, 10, 19, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 88, 1, new DateTime(2021, 10, 18, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 87, 1, new DateTime(2021, 10, 17, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) },
                    { 93, 1, new DateTime(2021, 10, 23, 16, 24, 58, 588, DateTimeKind.Local).AddTicks(5638) }
                });

            migrationBuilder.InsertData(
                table: "LotVaccin",
                columns: new[] { "Id", "CentreId", "DateEntree", "DateSortie", "FournisseurId", "QuantiteEntree", "QuantiteRestante", "TypeVaccinId" },
                values: new object[,]
                {
                    { 5, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 30, 30, 1 },
                    { 1, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 20, 20, 1 },
                    { 2, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 40, 40, 2 },
                    { 3, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 60, 60, 3 },
                    { 4, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 10, 10, 4 },
                    { 6, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 50, 50, 2 }
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
        }
    }
}

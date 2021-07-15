using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labo.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomRue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumRue = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CodePostal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeVaccin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeVaccin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Centre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResponsableId = table.Column<int>(type: "int", nullable: false),
                    AdressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Centre_Adress_AdressId",
                        column: x => x.AdressId,
                        principalTable: "Adress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fournisseur_Adress_AdressId",
                        column: x => x.AdressId,
                        principalTable: "Adress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistreNat = table.Column<string>(type: "nchar(11)", fixedLength: true, maxLength: 11, nullable: false),
                    Mail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    IndicMed = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.CheckConstraint("CK_Mail", "Mail LIKE '_%@_%'");
                    table.ForeignKey(
                        name: "FK_Patient_Adress_AdressId",
                        column: x => x.AdressId,
                        principalTable: "Adress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CalendrierJour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CentreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendrierJour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendrierJour_Centre_CentreId",
                        column: x => x.CentreId,
                        principalTable: "Centre",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HeureOuverture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jour = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    HeureDebut = table.Column<int>(type: "int", nullable: false),
                    HeureFin = table.Column<int>(type: "int", nullable: false),
                    CentreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeureOuverture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeureOuverture_Centre_CentreId",
                        column: x => x.CentreId,
                        principalTable: "Centre",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Inami = table.Column<long>(type: "bigint", fixedLength: true, maxLength: 11, nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    CentreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnel_Centre_CentreId",
                        column: x => x.CentreId,
                        principalTable: "Centre",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personnel_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LotVaccin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantiteEntree = table.Column<int>(type: "int", nullable: false),
                    QuantiteRestante = table.Column<int>(type: "int", nullable: false),
                    DateEntree = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSortie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CentreId = table.Column<int>(type: "int", nullable: false),
                    FournisseurId = table.Column<int>(type: "int", nullable: false),
                    TypeVaccinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotVaccin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LotVaccin_Centre_CentreId",
                        column: x => x.CentreId,
                        principalTable: "Centre",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LotVaccin_Fournisseur_FournisseurId",
                        column: x => x.FournisseurId,
                        principalTable: "Fournisseur",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LotVaccin_TypeVaccin_TypeVaccinId",
                        column: x => x.TypeVaccinId,
                        principalTable: "TypeVaccin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CalendrierHeure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<int>(type: "int", nullable: false),
                    CalendrierJourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendrierHeure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendrierHeure_CalendrierJour_CalendrierJourId",
                        column: x => x.CalendrierJourId,
                        principalTable: "CalendrierJour",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Injection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    CalendrierHeureId = table.Column<int>(type: "int", nullable: false),
                    PersonnelId = table.Column<int>(type: "int", nullable: false),
                    LotVaccinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Injection_CalendrierHeure_CalendrierHeureId",
                        column: x => x.CalendrierHeureId,
                        principalTable: "CalendrierHeure",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Injection_LotVaccin_LotVaccinId",
                        column: x => x.LotVaccinId,
                        principalTable: "LotVaccin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Injection_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Injection_Personnel_PersonnelId",
                        column: x => x.PersonnelId,
                        principalTable: "Personnel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adress",
                columns: new[] { "Id", "CodePostal", "NomRue", "NumRue", "Pays", "Ville" },
                values: new object[,]
                {
                    { 1, 5000, "rue de l'expo", "17A", "Belgique", "Namur" },
                    { 2, 5000, "rue du Centre", "17", "Belgique", "Namur" },
                    { 3, 5002, "rue à l'ouest", "35", "Belgique", "Saint-Servais" },
                    { 4, 5190, "rue à l'est", "17A", "Belgique", "Ham-sur-Sambre" },
                    { 5, 6000, "rue du pont", "19", "Belgique", "Charleroi" }
                });

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
                    { 1, 4, "Julie", "Edouard" },
                    { 2, 5, "Sophie", "Dufranne" }
                });

            migrationBuilder.InsertData(
                table: "HeureOuverture",
                columns: new[] { "Id", "CentreId", "HeureDebut", "HeureFin", "Jour" },
                values: new object[,]
                {
                    { 1, 1, 8, 20, 1 },
                    { 16, 3, 8, 20, 3 },
                    { 17, 3, 8, 20, 4 },
                    { 18, 3, 8, 22, 5 },
                    { 13, 2, 7, 18, 7 },
                    { 12, 2, 7, 18, 6 },
                    { 11, 2, 7, 18, 5 },
                    { 10, 2, 7, 18, 4 },
                    { 9, 2, 7, 18, 2 },
                    { 8, 2, 7, 18, 1 },
                    { 14, 3, 8, 20, 1 },
                    { 7, 1, 8, 22, 7 },
                    { 6, 1, 8, 20, 6 },
                    { 5, 1, 8, 20, 5 },
                    { 4, 1, 8, 20, 4 },
                    { 3, 1, 8, 20, 3 },
                    { 2, 1, 8, 20, 2 },
                    { 15, 3, 8, 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "LotVaccin",
                columns: new[] { "Id", "CentreId", "DateEntree", "DateSortie", "FournisseurId", "QuantiteEntree", "QuantiteRestante", "TypeVaccinId" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 600, 0, 3 },
                    { 5, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 300, 0, 1 },
                    { 2, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 400, 0, 2 },
                    { 1, 1, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 200, 0, 1 },
                    { 6, 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 500, 0, 2 },
                    { 4, 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "Id", "CentreId", "FirstName", "GradeId", "Inami", "LastName", "Password", "Salt" },
                values: new object[,]
                {
                    { 7, 2, "Marie", 3, 0L, "Durand", null, null },
                    { 6, 2, "Jean", 2, 12312312319L, "Poarr", null, null },
                    { 9, 3, "Pierre", 1, 12312312311L, "moraud", null, null },
                    { 10, 3, "Maud", 2, 12312312318L, "Perot", null, null },
                    { 11, 3, "Justine", 3, 0L, "Renson", null, null },
                    { 12, 3, "Patricia", 4, 0L, "Delrio", null, null },
                    { 4, 1, "Edouard", 4, 0L, "Perot", null, null },
                    { 3, 1, "Marie", 3, 0L, "Dupont", null, null },
                    { 2, 1, "Jean", 2, 12312312312L, "Jacques", null, null },
                    { 1, 1, "Pierre", 1, 12312312312L, "Wasnaire", null, null },
                    { 8, 2, "Josef", 4, 0L, "quier", null, null },
                    { 5, 2, "Pol", 1, 12312312317L, "Wasnaire", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalendrierHeure_CalendrierJourId",
                table: "CalendrierHeure",
                column: "CalendrierJourId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendrierJour_CentreId",
                table: "CalendrierJour",
                column: "CentreId");

            migrationBuilder.CreateIndex(
                name: "IX_Centre_AdressId",
                table: "Centre",
                column: "AdressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fournisseur_AdressId",
                table: "Fournisseur",
                column: "AdressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HeureOuverture_CentreId",
                table: "HeureOuverture",
                column: "CentreId");

            migrationBuilder.CreateIndex(
                name: "IX_Injection_CalendrierHeureId",
                table: "Injection",
                column: "CalendrierHeureId");

            migrationBuilder.CreateIndex(
                name: "IX_Injection_LotVaccinId",
                table: "Injection",
                column: "LotVaccinId");

            migrationBuilder.CreateIndex(
                name: "IX_Injection_PatientId",
                table: "Injection",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Injection_PersonnelId",
                table: "Injection",
                column: "PersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_LotVaccin_CentreId",
                table: "LotVaccin",
                column: "CentreId");

            migrationBuilder.CreateIndex(
                name: "IX_LotVaccin_FournisseurId",
                table: "LotVaccin",
                column: "FournisseurId");

            migrationBuilder.CreateIndex(
                name: "IX_LotVaccin_TypeVaccinId",
                table: "LotVaccin",
                column: "TypeVaccinId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AdressId",
                table: "Patient",
                column: "AdressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Mail",
                table: "Patient",
                column: "Mail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_CentreId",
                table: "Personnel",
                column: "CentreId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_GradeId",
                table: "Personnel",
                column: "GradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeureOuverture");

            migrationBuilder.DropTable(
                name: "Injection");

            migrationBuilder.DropTable(
                name: "CalendrierHeure");

            migrationBuilder.DropTable(
                name: "LotVaccin");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropTable(
                name: "CalendrierJour");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "TypeVaccin");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Centre");

            migrationBuilder.DropTable(
                name: "Adress");
        }
    }
}

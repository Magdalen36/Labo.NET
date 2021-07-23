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
                    CodePostal = table.Column<long>(type: "bigint", nullable: false)
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
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
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
                    Inami = table.Column<long>(type: "bigint", fixedLength: true, maxLength: 11, nullable: true),
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
                    DateSortie = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Heure = table.Column<int>(type: "int", nullable: false),
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
                    PersonnelId = table.Column<int>(type: "int", nullable: true),
                    LotVaccinId = table.Column<int>(type: "int", nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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

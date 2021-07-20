﻿// <auto-generated />
using System;
using Labo.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labo.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210719142254_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labo.DAL.Entities.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CodePostal")
                        .HasColumnType("bigint");

                    b.Property<string>("NomRue")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumRue")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierHeure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalendrierJourId")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendrierJourId");

                    b.ToTable("CalendrierHeure");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierJour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CentreId");

                    b.ToTable("CalendrierJour");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Centre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ResponsableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.ToTable("Centre");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Fournisseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.ToTable("Fournisseur");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("Labo.DAL.Entities.HeureOuverture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentreId")
                        .HasColumnType("int");

                    b.Property<int>("HeureDebut")
                        .HasColumnType("int");

                    b.Property<int>("HeureFin")
                        .HasColumnType("int");

                    b.Property<int>("Jour")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CentreId");

                    b.ToTable("HeureOuverture");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Injection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalendrierHeureId")
                        .HasColumnType("int");

                    b.Property<int>("LotVaccinId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PersonnelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendrierHeureId");

                    b.HasIndex("LotVaccinId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PersonnelId");

                    b.ToTable("Injection");
                });

            modelBuilder.Entity("Labo.DAL.Entities.LotVaccin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEntree")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSortie")
                        .HasColumnType("datetime2");

                    b.Property<int>("FournisseurId")
                        .HasColumnType("int");

                    b.Property<int>("QuantiteEntree")
                        .HasColumnType("int");

                    b.Property<int>("QuantiteRestante")
                        .HasColumnType("int");

                    b.Property<int>("TypeVaccinId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CentreId");

                    b.HasIndex("FournisseurId");

                    b.HasIndex("TypeVaccinId");

                    b.ToTable("LotVaccin");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IndicMed")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("RegistreNat")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nchar(11)")
                        .IsFixedLength(true);

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdressId")
                        .IsUnique();

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.ToTable("Patient");

                    b.HasCheckConstraint("CK_Mail", "Mail LIKE '_%@_%'");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Personnel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentreId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<long>("Inami")
                        .HasMaxLength(11)
                        .HasColumnType("bigint")
                        .IsFixedLength(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CentreId");

                    b.HasIndex("GradeId");

                    b.ToTable("Personnel");
                });

            modelBuilder.Entity("Labo.DAL.Entities.TypeVaccin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeVaccin");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierHeure", b =>
                {
                    b.HasOne("Labo.DAL.Entities.CalendrierJour", "CalendrierJour")
                        .WithMany("CalendrierHeures")
                        .HasForeignKey("CalendrierJourId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CalendrierJour");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierJour", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Centre", "Centre")
                        .WithMany("CalendrierJours")
                        .HasForeignKey("CentreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Centre");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Centre", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Adress", "Adress")
                        .WithOne("Centre")
                        .HasForeignKey("Labo.DAL.Entities.Centre", "AdressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Fournisseur", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Adress", "Adress")
                        .WithOne("Fournisseur")
                        .HasForeignKey("Labo.DAL.Entities.Fournisseur", "AdressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Labo.DAL.Entities.HeureOuverture", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Centre", "Centre")
                        .WithMany("HeureOuvertures")
                        .HasForeignKey("CentreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Centre");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Injection", b =>
                {
                    b.HasOne("Labo.DAL.Entities.CalendrierHeure", "CalendrierHeure")
                        .WithMany("Injections")
                        .HasForeignKey("CalendrierHeureId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.LotVaccin", "LotVaccin")
                        .WithMany()
                        .HasForeignKey("LotVaccinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.Patient", "Patient")
                        .WithMany("Injections")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalendrierHeure");

                    b.Navigation("LotVaccin");

                    b.Navigation("Patient");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("Labo.DAL.Entities.LotVaccin", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Centre", "Centre")
                        .WithMany("LotVaccins")
                        .HasForeignKey("CentreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.Fournisseur", "Fournisseur")
                        .WithMany("LotVaccins")
                        .HasForeignKey("FournisseurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.TypeVaccin", "TypeVaccin")
                        .WithMany("LotVaccins")
                        .HasForeignKey("TypeVaccinId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Centre");

                    b.Navigation("Fournisseur");

                    b.Navigation("TypeVaccin");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Patient", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Adress", "Adress")
                        .WithOne("Patient")
                        .HasForeignKey("Labo.DAL.Entities.Patient", "AdressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Adress");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Personnel", b =>
                {
                    b.HasOne("Labo.DAL.Entities.Centre", "Centre")
                        .WithMany("Personnels")
                        .HasForeignKey("CentreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Labo.DAL.Entities.Grade", "Grade")
                        .WithMany("Personnels")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Centre");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Adress", b =>
                {
                    b.Navigation("Centre");

                    b.Navigation("Fournisseur");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierHeure", b =>
                {
                    b.Navigation("Injections");
                });

            modelBuilder.Entity("Labo.DAL.Entities.CalendrierJour", b =>
                {
                    b.Navigation("CalendrierHeures");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Centre", b =>
                {
                    b.Navigation("CalendrierJours");

                    b.Navigation("HeureOuvertures");

                    b.Navigation("LotVaccins");

                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Fournisseur", b =>
                {
                    b.Navigation("LotVaccins");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Grade", b =>
                {
                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("Labo.DAL.Entities.Patient", b =>
                {
                    b.Navigation("Injections");
                });

            modelBuilder.Entity("Labo.DAL.Entities.TypeVaccin", b =>
                {
                    b.Navigation("LotVaccins");
                });
#pragma warning restore 612, 618
        }
    }
}

using Labo.DAL.DataSet;
using Labo.DAL.Entities;
using Labo.DAL.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL
{
    public class DataContext : DbContext
    {

        public DbSet<CalendrierHeure> CalendrierHeures { get; set; }
        public DbSet<CalendrierJour> CalendrierJours { get; set; }
        public DbSet<Centre> Centres { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Injection> Injections { get; set; }
        public DbSet<LotVaccin> LotVaccins { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<TypeVaccin> TypeVaccins { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<HeureOuverture> HeureOuvertures { get; set; }

        private readonly string _defaultConnectionString = @"Server=localhost;Database=LaboVaccin;Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_defaultConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuration
            modelBuilder.ApplyConfiguration(new CalendrierJourConfiguration());
            modelBuilder.ApplyConfiguration(new CalendrierHeureConfiguration());
            modelBuilder.ApplyConfiguration(new CentreConfiguration());
            modelBuilder.ApplyConfiguration(new FournisseurConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
            modelBuilder.ApplyConfiguration(new InjectionConfiguration());
            modelBuilder.ApplyConfiguration(new LotVaccinConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PersonnelConfiguration());
            modelBuilder.ApplyConfiguration(new TypeVaccinConfiguration());
            modelBuilder.ApplyConfiguration(new AdressConfiguration());
            modelBuilder.ApplyConfiguration(new HeureOuvertureConfiguration());

            //dataset
            modelBuilder.ApplyConfiguration(new DataSetTypeVaccin());
            modelBuilder.ApplyConfiguration(new DataSetGrade());
            ////modelBuilder.ApplyConfiguration(new DataSetAdress());
            ////modelBuilder.ApplyConfiguration(new DataSetPersonnel());
            modelBuilder.ApplyConfiguration(new DataSetFournisseur());
            modelBuilder.ApplyConfiguration(new DataSetCentre());
            modelBuilder.ApplyConfiguration(new DataSetHeureOuverture());
            modelBuilder.ApplyConfiguration(new DataSetLotVaccin());
            modelBuilder.ApplyConfiguration(new DataSetCalendrierJour());          
        }
    }
}

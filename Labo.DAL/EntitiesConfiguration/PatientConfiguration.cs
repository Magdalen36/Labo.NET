using Labo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.EntitiesConfiguration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable(nameof(Patient));
            builder.HasKey(p => p.Id);

            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p => p.RegistreNat).IsRequired().HasMaxLength(11).IsFixedLength();
            builder.Property(p => p.Password).IsRequired();

            builder.Property(p => p.Mail)
                .HasMaxLength(255)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(p => p.PhoneNumber).IsRequired();
            builder.Property(p => p.IndicMed).IsRequired().HasMaxLength(1000);

            builder.HasMany(i => i.Injections)
                    .WithOne(p => p.Patient)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Adress)
                    .WithOne(c => c.Patient)
                    .HasForeignKey<Patient>(c => c.AdressId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasCheckConstraint("CK_Mail", "Mail LIKE '_%@_%'")
                   .HasIndex(p => p.Mail)
                   .IsUnique();
        }
    }
}

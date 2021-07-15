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
    public class CentreConfiguration : IEntityTypeConfiguration<Centre>
    {
        public void Configure(EntityTypeBuilder<Centre> builder)
        {
            builder.ToTable(nameof(Centre));
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);          

            //builder.HasOne(p => p.Responsable)
            //        .WithOne(c => c.Centre);

            builder.HasMany(p => p.Personnels)
                    .WithOne(c => c.Centre)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(l => l.LotVaccins)
                    .WithOne(c => c.Centre)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.CalendrierJours)
                    .WithOne(c => c.Centre)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.HeureOuvertures)
                    .WithOne(c => c.Centre)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Adress)
                    .WithOne(c => c.Centre)
                    .HasForeignKey<Centre>(c => c.AdressId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

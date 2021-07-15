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
    public class FournisseurConfiguration : IEntityTypeConfiguration<Fournisseur>
    {
        public void Configure(EntityTypeBuilder<Fournisseur> builder)
        {
            builder.ToTable(nameof(Fournisseur));
            builder.HasKey(f => f.Id);

            builder.Property(f => f.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(f => f.LastName).IsRequired().HasMaxLength(50);

            builder.HasMany(l => l.LotVaccins)
                    .WithOne(f => f.Fournisseur)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Adress)
                    .WithOne(c => c.Fournisseur)
                    .HasForeignKey<Fournisseur>(c => c.AdressId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

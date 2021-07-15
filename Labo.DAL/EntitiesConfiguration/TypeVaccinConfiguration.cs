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
    public class TypeVaccinConfiguration : IEntityTypeConfiguration<TypeVaccin>
    {
        public void Configure(EntityTypeBuilder<TypeVaccin> builder)
        {
            builder.ToTable(nameof(TypeVaccin));
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired();

            builder.HasMany(l => l.LotVaccins)
                    .WithOne(t => t.TypeVaccin)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

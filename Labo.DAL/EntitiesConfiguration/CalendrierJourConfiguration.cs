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
    public class CalendrierJourConfiguration : IEntityTypeConfiguration<CalendrierJour>
    {
        public void Configure(EntityTypeBuilder<CalendrierJour> builder)
        {
            builder.ToTable(nameof(CalendrierJour));
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Day).IsRequired();

            builder.HasMany(c => c.CalendrierHeures)
                    .WithOne(c => c.CalendrierJour)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

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
    public class CalendrierHeureConfiguration : IEntityTypeConfiguration<CalendrierHeure>
    {
        public void Configure(EntityTypeBuilder<CalendrierHeure> builder)
        {
            builder.ToTable(nameof(CalendrierHeure));
            builder.HasKey(c => c.Id);

            builder.HasMany(i => i.Injections)
                    .WithOne(c => c.CalendrierHeure)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

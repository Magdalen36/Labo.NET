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
    public class LotVaccinConfiguration : IEntityTypeConfiguration<LotVaccin>
    {
        public void Configure(EntityTypeBuilder<LotVaccin> builder)
        {
            builder.ToTable(nameof(LotVaccin));
            builder.HasKey(l => l.Id);

            builder.Property(l => l.QuantiteEntree).IsRequired();
            builder.Property(l => l.DateEntree).IsRequired();
            builder.Property(l => l.QuantiteRestante).IsRequired();

        }
    }
}

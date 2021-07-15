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
    public class HeureOuvertureConfiguration : IEntityTypeConfiguration<HeureOuverture>
    {
        public void Configure(EntityTypeBuilder<HeureOuverture> builder)
        {
            builder.ToTable(nameof(HeureOuverture));

            builder.HasKey(h => h.Id);

            builder.Property(h => h.Jour).IsRequired().HasMaxLength(1);
            builder.Property(h => h.HeureDebut).IsRequired();
            builder.Property(h => h.HeureFin).IsRequired();
        }
    }
}

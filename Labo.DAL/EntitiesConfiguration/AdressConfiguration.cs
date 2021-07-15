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
    public class AdressConfiguration : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.ToTable(nameof(Adress));
            builder.HasKey(a => a.Id);

            builder.Property(a => a.NomRue).IsRequired().HasMaxLength(50);
            builder.Property(a => a.NumRue).IsRequired().HasMaxLength(20);
            builder.Property(a => a.Ville).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Pays).IsRequired().HasMaxLength(30);
            builder.Property(a => a.CodePostal).IsRequired();

        }
    }
}

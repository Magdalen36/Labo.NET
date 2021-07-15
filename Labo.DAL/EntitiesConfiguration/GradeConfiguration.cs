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
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable(nameof(Grade));
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Name).IsRequired();

            builder.HasMany(p => p.Personnels)
                    .WithOne(g => g.Grade)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

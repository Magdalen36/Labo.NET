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
    public class InjectionConfiguration : IEntityTypeConfiguration<Injection>
    {
        public void Configure(EntityTypeBuilder<Injection> builder)
        {
            builder.ToTable(nameof(Injection));
            builder.HasKey(i => i.Id);

            builder.Property(p => p.PatientId).IsRequired(); 
            builder.Property(p => p.CalendrierHeureId).IsRequired(); 
        }
    }
}

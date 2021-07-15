using Labo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.DataSet
{
    public class DataSetTypeVaccin : IEntityTypeConfiguration<TypeVaccin>
    {
        public void Configure(EntityTypeBuilder<TypeVaccin> builder)
        {
            builder.HasData(
                new TypeVaccin { Id = 1, Name = "Moderna" },
                new TypeVaccin { Id = 2, Name = "Pfizer" },
                new TypeVaccin { Id = 3, Name = "Johnson & Johnson" },
                new TypeVaccin { Id = 4, Name = "AstraZeneca" }
            );
        }
    }
}

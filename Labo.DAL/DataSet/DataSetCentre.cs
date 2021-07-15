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
    public class DataSetCentre : IEntityTypeConfiguration<Centre>
    {
        public void Configure(EntityTypeBuilder<Centre> builder)
        {
            builder.HasData(
                new Centre { Id = 1, Name = "Namur Expo", ResponsableId = 1, AdressId = 1 },
                new Centre { Id = 2, Name = "Centre Central", ResponsableId = 5, AdressId = 2 },
                new Centre { Id = 3, Name = "Hall Saint-Servais", ResponsableId = 9, AdressId = 3 }
                );
        }
    }
}

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
    public class DataSetFournisseur : IEntityTypeConfiguration<Fournisseur>
    {
        public void Configure(EntityTypeBuilder<Fournisseur> builder)
        {
            builder.HasData(
                new Fournisseur { Id = 1,FirstName = "Julie", LastName = "Edouard", AdressId = 4},
                new Fournisseur { Id = 2,FirstName = "Sophie", LastName = "Dufranne", AdressId = 5}
                );
        }
    }
}

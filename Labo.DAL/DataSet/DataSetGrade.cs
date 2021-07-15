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
    public class DataSetGrade : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasData(
                new Grade { Id = 1, Name = "Médecin"},
                new Grade { Id = 2, Name = "Infirmier"},
                new Grade { Id = 3, Name = "Sécurité"},
                new Grade { Id = 4, Name = "Bénévole"}
                );
        }
    }
}

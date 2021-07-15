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
    public class DataSetPersonnel : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.HasData(
                new Personnel
                {
                    Id = 1,
                    FirstName = "Pierre",
                    LastName = "Wasnaire",
                    GradeId = 1,
                    Inami = 12312312312,
                    CentreId = 1                 
                },
                new Personnel
                {
                    Id = 2,
                    FirstName = "Jean",
                    LastName = "Jacques",
                    GradeId = 2,
                    Inami = 12312312312,
                    CentreId = 1
                },
                new Personnel
                {
                    Id = 3,
                    FirstName = "Marie",
                    LastName = "Dupont",
                    GradeId = 3,
                    CentreId = 1
                },
                new Personnel
                {
                    Id = 4,
                    FirstName = "Edouard",
                    LastName = "Perot",
                    GradeId = 4,
                    CentreId = 1
                },
                new Personnel
                {
                    Id = 5,
                    FirstName = "Pol",
                    LastName = "Wasnaire",
                    GradeId = 1,
                    Inami = 12312312317,
                    CentreId = 2
                },
                new Personnel
                {
                    Id = 6,
                    FirstName = "Jean",
                    LastName = "Poarr",
                    GradeId = 2,
                    Inami = 12312312319,
                    CentreId = 2
                },
                new Personnel
                {
                    Id = 7,
                    FirstName = "Marie",
                    LastName = "Durand",
                    GradeId = 3,
                    CentreId = 2
                },
                new Personnel
                {
                    Id = 8,
                    FirstName = "Josef",
                    LastName = "quier",
                    GradeId = 4,
                    CentreId = 2
                },
                new Personnel
                {
                    Id = 9,
                    FirstName = "Pierre",
                    LastName = "moraud",
                    GradeId = 1,
                    Inami = 12312312311,
                    CentreId = 3
                },
                new Personnel
                {
                    Id = 10,
                    FirstName = "Maud",
                    LastName = "Perot",
                    GradeId = 2,
                    Inami = 12312312318,
                    CentreId = 3
                },
                new Personnel
                {
                    Id = 11,
                    FirstName = "Justine",
                    LastName = "Renson",
                    GradeId = 3,
                    CentreId = 3
                },
                new Personnel
                {
                    Id = 12,
                    FirstName = "Patricia",
                    LastName = "Delrio",
                    GradeId = 4,
                    CentreId = 3
                }
                ); 
        }
    }
}

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
    public class DataSetPatient : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
                new Patient
                {
                    Id = 1,
                    LastName = "Jon",
                    FirstName = "Copain",
                    BirthDate = new DateTime(1985, 02, 02),
                    RegistreNat = "12332112312",
                    Mail = "joe@gmail.com",
                    PhoneNumber = 0474563521,
                    IndicMed = "",
                    AdressId = 1
                }
                );
        }
    }
}


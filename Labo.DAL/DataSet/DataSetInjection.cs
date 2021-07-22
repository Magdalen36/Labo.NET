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
    public class DataSetInjection : IEntityTypeConfiguration<Injection>
    {
        public void Configure(EntityTypeBuilder<Injection> builder)
        {
            builder.HasData(
                new Injection { Id = 1, PatientId = 1, CalendrierHeureId = 1}
                //new Injection {Id = 2, PatientId = 2, CalendrierHeureId = 2},
                //new Injection {Id = 3, PatientId = 3, CalendrierHeureId = 3},
                //new Injection {Id = 4, PatientId = 4, CalendrierHeureId = 4},
                //new Injection {Id = 5, PatientId = 5, CalendrierHeureId = 5},
                //new Injection {Id = 6, PatientId = 6, CalendrierHeureId = 6},
                //new Injection {Id = 7, PatientId = 7, CalendrierHeureId = 7},
                //new Injection {Id = 8, PatientId = 8, CalendrierHeureId = 8},
                //new Injection {Id = 9, PatientId = 9, CalendrierHeureId = 9},
                //new Injection {Id = 10, PatientId = 10, CalendrierHeureId = 10}
                ) ;
        }
    }
}

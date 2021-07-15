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
    public class DataSetLotVaccin : IEntityTypeConfiguration<LotVaccin>
    {
        public void Configure(EntityTypeBuilder<LotVaccin> builder)
        {
            builder.HasData(
                new LotVaccin { Id = 1, CentreId = 1, TypeVaccinId = 1, QuantiteEntree = 200, DateEntree = new DateTime(2021,07,15), FournisseurId = 1 },
                new LotVaccin { Id = 2, CentreId = 1, TypeVaccinId = 2, QuantiteEntree = 400, DateEntree = new DateTime(2021, 07, 15), FournisseurId = 2 },
                new LotVaccin { Id = 3, CentreId = 2, TypeVaccinId = 3, QuantiteEntree = 600, DateEntree = new DateTime(2021, 07, 15), FournisseurId = 1 },
                new LotVaccin { Id = 4, CentreId = 2, TypeVaccinId = 4, QuantiteEntree = 100, DateEntree = new DateTime(2021, 07, 15), FournisseurId = 2 },
                new LotVaccin { Id = 5, CentreId = 3, TypeVaccinId = 1, QuantiteEntree = 300, DateEntree = new DateTime(2021, 07, 15), FournisseurId = 1 },
                new LotVaccin { Id = 6, CentreId = 3, TypeVaccinId = 2, QuantiteEntree = 500, DateEntree = new DateTime(2021, 07, 15), FournisseurId = 2 }
                );
        }
    }
}

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
    public class DataSetHeureOuverture : IEntityTypeConfiguration<HeureOuverture>
    {
        public void Configure(EntityTypeBuilder<HeureOuverture> builder)
        {
            builder.HasData(
                new HeureOuverture { Id = 1, Jour = 1, HeureDebut = 8, HeureFin = 20, CentreId = 1},
                new HeureOuverture { Id = 2, Jour = 2, HeureDebut = 8, HeureFin = 20, CentreId = 1 },
                new HeureOuverture { Id = 3, Jour = 3, HeureDebut = 8, HeureFin = 20, CentreId = 1 },
                new HeureOuverture { Id = 4, Jour = 4, HeureDebut = 8, HeureFin = 20, CentreId = 1 },
                new HeureOuverture { Id = 5, Jour = 5, HeureDebut = 8, HeureFin = 20, CentreId = 1 },
                new HeureOuverture { Id = 6, Jour = 6, HeureDebut = 8, HeureFin = 20, CentreId = 1 },
                new HeureOuverture { Id = 7, Jour = 7, HeureDebut = 8, HeureFin = 22, CentreId = 1 },

                new HeureOuverture { Id = 8, Jour = 1, HeureDebut = 7, HeureFin = 18, CentreId = 2 },
                new HeureOuverture { Id = 9, Jour = 2, HeureDebut = 7, HeureFin = 18, CentreId = 2 },
                new HeureOuverture { Id = 10, Jour = 4, HeureDebut = 7, HeureFin = 18, CentreId = 2 },
                new HeureOuverture { Id = 11, Jour = 5, HeureDebut = 7, HeureFin = 18, CentreId = 2 },
                new HeureOuverture { Id = 12, Jour = 6, HeureDebut = 7, HeureFin = 18, CentreId = 2 },
                new HeureOuverture { Id = 13, Jour = 7, HeureDebut = 7, HeureFin = 18, CentreId = 2 },

                new HeureOuverture { Id = 14, Jour = 1, HeureDebut = 8, HeureFin = 20, CentreId = 3 },
                new HeureOuverture { Id = 15, Jour = 2, HeureDebut = 8, HeureFin = 20, CentreId = 3 },
                new HeureOuverture { Id = 16, Jour = 3, HeureDebut = 8, HeureFin = 20, CentreId = 3 },
                new HeureOuverture { Id = 17, Jour = 4, HeureDebut = 8, HeureFin = 20, CentreId = 3 },
                new HeureOuverture { Id = 18, Jour = 5, HeureDebut = 8, HeureFin = 22, CentreId = 3 }
                ) ;
        }
    }
}

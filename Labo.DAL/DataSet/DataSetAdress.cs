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
    public class DataSetAdress : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.HasData(
                new Adress {
                    Id = 1,
                    NomRue = "rue de l'expo",
                    NumRue = "17A",
                    CodePostal = 5000,
                    Ville = "Namur",
                    Pays = "Belgique"
                },
                new Adress
                {
                    Id = 2,
                    NomRue = "rue du Centre",
                    NumRue = "17",
                    CodePostal = 5000,
                    Ville = "Namur",
                    Pays = "Belgique"
                },
                new Adress
                {
                    Id = 3,
                    NomRue = "rue à l'ouest",
                    NumRue = "35",
                    CodePostal = 5002,
                    Ville = "Saint-Servais",
                    Pays = "Belgique"
                },
                new Adress
                {
                    Id = 4,
                    NomRue = "rue à l'est",
                    NumRue = "17A",
                    CodePostal = 5190,
                    Ville = "Ham-sur-Sambre",
                    Pays = "Belgique"
                },
                new Adress
                {
                    Id = 5,
                    NomRue = "rue du pont",
                    NumRue = "19",
                    CodePostal = 6000,
                    Ville = "Charleroi",
                    Pays = "Belgique"
                }
                );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class LotVaccin
    {
        public int Id { get; set; }
        public int QuantiteEntree { get; set; }
        public int QuantiteRestante { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime DateSortie { get; set; }

        public int CentreId { get; set; }
        public virtual Centre Centre { get; set; }

        public int FournisseurId { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }

        public int TypeVaccinId { get; set; }
        public virtual TypeVaccin TypeVaccin { get; set; }

    }
}

using Labo.ASP.Models.Forms;
using Labo.ASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models
{
    public class StockVaccinModel
    {
        public int Id { get; set; }
        public int QuantiteEntree { get; set; }
        public int QuantiteRestante { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime? DateSortie { get; set; }

        public int CentreId { get; set; }

        public string NameFournisseur { get; set; }
        public int IdAdressFournisseur { get; set; }

        public string NomRueF { get; set; }
        public string NumRueF { get; set; }
        public string VilleF { get; set; }
        public string PaysF { get; set; }
        public long CodePostalF { get; set; }

        public string NameTypeVaccin { get; set; }
    }
}

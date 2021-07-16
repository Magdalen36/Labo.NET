using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models
{
    public class DetailCentreModel
    {

        public string NomRue { get; set; }
        public string NumRue { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public int CodePostal { get; set; }

        public string NameR { get; set; }

        public Dictionary<string, string> HeuresOuverture { get; set; }

        public List<string> TypeVaccin { get; set; }
    }
}

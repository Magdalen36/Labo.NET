using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models
{
    public class DetailCentreModel
    {
        public int IdAdress { get; set; }
        public string NomRue { get; set; }
        public string NumRue { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public int CodePostal { get; set; }

        public int IdR { get; set; }
        public string NameR { get; set; }

        public int IdHO { get; set; }
        public List<string> HeuresOuverture { get; set; }
    }
}

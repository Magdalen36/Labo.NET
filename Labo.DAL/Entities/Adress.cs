using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class Adress
    {
        public int Id { get; set; }
        public string NomRue { get; set; }
        public string NumRue { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public long CodePostal { get; set; }

        public virtual Fournisseur Fournisseur { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Centre Centre { get; set; }
    }
}

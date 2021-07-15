using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class Fournisseur
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int AdressId { get; set; }
        public Adress Adress { get; set; }

        public virtual IEnumerable<LotVaccin> LotVaccins{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class Centre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ResponsableId { get; set; }
        //public virtual Personnel Responsable { get; set; }

        public int AdressId { get; set; }
        public Adress Adress { get; set; }

        public virtual IEnumerable<Personnel> Personnels { get; set; }
        public virtual IEnumerable<LotVaccin> LotVaccins { get; set; }
        public virtual IEnumerable<CalendrierJour> CalendrierJours { get; set; }
        public virtual IEnumerable<HeureOuverture> HeureOuvertures { get; set; }
    }
}

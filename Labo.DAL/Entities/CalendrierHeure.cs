using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class CalendrierHeure
    {
        public int Id { get; set; }
        public int Heure { get; set; }
        public int Time { get; set; } 


        public int CalendrierJourId { get; set; }
        public virtual CalendrierJour CalendrierJour { get; set; }

        public virtual IEnumerable<Injection> Injections { get; set; }
    }
}

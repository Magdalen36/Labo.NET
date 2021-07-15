using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class CalendrierJour
    {
        public int Id { get; set; }
        public DateTime Day { get; set; }
    
        public int CentreId { get; set; }
        public virtual Centre Centre { get; set; }

        public virtual IEnumerable<CalendrierHeure> CalendrierHeures { get; set; }
    }
}

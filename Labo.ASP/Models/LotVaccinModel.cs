using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models
{
    public class LotVaccinModel
    {
        public int Id { get; set; }
        //public int QuantiteEntree { get; set; }
        //public int QuantiteRestante { get; set; }
        //public DateTime DateEntree { get; set; }
        //public DateTime DateSortie { get; set; }        

        public List<string> TypeVaccin { get; set; }
        
    }
}

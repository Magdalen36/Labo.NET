using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models
{
    public class HeureOuvertureModel
    {
        public int Id { get; set; }
        public int Jour { get; set; }
        public int HeureDebut { get; set; }
        public int HeureFin { get; set; }
    }
}

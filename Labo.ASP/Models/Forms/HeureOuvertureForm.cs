using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models.Forms
{
    public class HeureOuvertureForm
    {
        public int Id { get; set; }
        public int Jour { get; set; }
        public int HeureDebut { get; set; }
        public int HeureFin { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class HeureOuverture
    {
        public int Id { get; set; }
        public int Jour { get; set; }
        public int HeureDebut { get; set; }
        public int HeureFin { get; set; }

        public int CentreId { get; set; }
        public Centre Centre { get; set; }
    }
}

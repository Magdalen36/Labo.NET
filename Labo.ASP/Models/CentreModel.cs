using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models
{
    public class CentreModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ResponsableId { get; set; }

        public int AdressId { get; set; }

        public string Ville { get; set; }
    }
}

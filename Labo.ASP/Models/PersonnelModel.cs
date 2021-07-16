using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models
{
    public class PersonnelModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long Inami { get; set; }
        //public byte[] Password { get; set; }
        //public string Salt { get; set; }

        public string NomGrade { get; set; }

        public int CentreId { get; set; }
        public string NomCentre { get; set; }


    }
}

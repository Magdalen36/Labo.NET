using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models.Forms
{
    public class PersonnelForm
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long? Inami { get; set; }
        public string PasswordIn { get; set; }
        public string Salt { get; set; }

        public int GradeId { get; set; }

        public int CentreId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Personnel> Personnels { get; set; }
    }
}

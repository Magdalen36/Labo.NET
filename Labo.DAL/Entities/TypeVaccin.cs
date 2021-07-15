using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class TypeVaccin
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<LotVaccin> LotVaccins { get; set; }
    }
}

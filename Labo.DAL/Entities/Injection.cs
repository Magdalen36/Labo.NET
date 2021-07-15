using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class Injection
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public int CalendrierHeureId { get; set; }
        public virtual CalendrierHeure CalendrierHeure { get; set; }

        public int PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }

        public int LotVaccinId { get; set; }
        public virtual LotVaccin LotVaccin { get; set; }
    }
}

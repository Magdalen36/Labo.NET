using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models.Forms
{
    public class InjectionForm
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public string PatientName { get; set; }

        public int CalendrierHeureId { get; set; }
        public DateTime CalendrierJour { get; set; }

        public int? PersonnelId { get; set; }
        public string PersonnelName { get; set; }

        public int? LotVaccinId { get; set; }

    }
}

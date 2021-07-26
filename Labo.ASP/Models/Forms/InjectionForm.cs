using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DataType(DataType.Date)] //Permet de formater la date pour ne pas avoir les heures 
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CalendrierJour { get; set; }

        public int? PersonnelId { get; set; }
        public string PersonnelName { get; set; }

        public int? LotVaccinId { get; set; }

    }
}

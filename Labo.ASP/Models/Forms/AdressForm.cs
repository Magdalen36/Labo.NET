using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Models.Forms
{
    public class AdressForm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        [MaxLength(50, ErrorMessage = "Le champs doit faire maximum 50 caractères.")]
        public string NomRue { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        [MaxLength(20, ErrorMessage = "Le champs doit faire maximum 20 caractères.")]
        public string NumRue { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        [MaxLength(30, ErrorMessage = "Le champs doit faire maximum 30 caractères.")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        [MaxLength(10, ErrorMessage = "Le champs doit faire maximum 10 caractères.")]
        public long CodePostal { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        [MaxLength(30, ErrorMessage = "Le champs doit faire maximum 30 caractères.")]
        public string Pays { get; set; }
 
    }
}

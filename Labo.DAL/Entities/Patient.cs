using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string RegistreNat { get; set; }
        public string Mail { get; set; }
        public long PhoneNumber { get; set; }
        public string IndicMed { get; set; }
        public byte[] Password { get; set; }
        public string Salt { get; set; }

        public int AdressId { get; set; }
        public Adress Adress { get; set; }

        public virtual IEnumerable<Injection> Injections { get; set; }
    }
}

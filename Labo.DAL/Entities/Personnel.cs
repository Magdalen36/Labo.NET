using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.DAL.Entities
{
    public class Personnel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long? Inami { get; set; }
        public byte[] Password { get; set; }
        public string Salt { get; set; }

        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }

        public int CentreId { get; set; }
        public virtual Centre Centre { get; set; }
    }
}

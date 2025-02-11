﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Labo.ASP.Models
{
    public class PersonnelModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public long? Inami { get; set; }

        public byte[] PasswordOut
        {
            get
            {
                return HashMe(PasswordIn);
            }
        }

        public string PasswordIn { get; set; }

        //public string Salt { get; set; }

        public string NomGrade { get; set; }
        public int GradeId { get; set; }

        public int CentreId { get; set; }
        public string NomCentre { get; set; }

        public byte[] HashMe(string passwordIn)
        {

            byte[] data = Encoding.UTF8.GetBytes(passwordIn);
            byte[] result;
            SHA512 shaM = new SHA512Managed();
            result = shaM.ComputeHash(data);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Populate
{
    public class PasswordHash
    {
        public byte[] PasswordOut
        {
            get
            {
                return HashMe(PasswordIn);
            }
        }
        public string PasswordIn { get; set; }

        public byte[] HashMe(string passwordIn) //attention, en private normalement
        {
            byte[] data = Encoding.UTF8.GetBytes(passwordIn);
            byte[] result;
            SHA512 shaM = new SHA512Managed();
            result = shaM.ComputeHash(data);
            return result;
        }
    }
}

using Labo.ASP.Models;
using Labo.ASP.Models.Forms;
using Labo.DAL;
using Labo.DAL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Labo.ASP.Services
{
    public class AdressService : IService<AdressModel, AdressForm>
    {
        private readonly DataContext _dc;

        public AdressService(DataContext dc)
        {
            _dc = dc;
        }

        public bool Delete(int d)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdressModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public AdressForm GetById(int id)
        {
            Adress toFind = _dc.Adresses.Find(id);
            if (toFind != null)
            {
                return new AdressForm
                {
                    Id = toFind.Id,
                    NomRue = toFind.NomRue,
                    NumRue = toFind.NumRue,
                    CodePostal = toFind.CodePostal,
                    Ville = toFind.Ville,
                    Pays = toFind.Pays
                };
            }
            else return null;
        }

        public void Insert(AdressForm form)
        {
            throw new NotImplementedException();
        }

        public void Update(AdressForm form)
        {
            throw new NotImplementedException();
        }

    }   
}

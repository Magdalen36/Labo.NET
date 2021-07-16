using Labo.ASP.Models;
using Labo.ASP.Models.Forms;
using Labo.DAL;
using Labo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Services
{
    public class LotVaccinService : IService<LotVaccinModel, LotVaccinForm>
    {
        private readonly DataContext _dc;

        public LotVaccinService(DataContext dc)
        {
            _dc = dc;
        }

        public bool Delete(int d)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LotVaccinModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public LotVaccinForm GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetByCentreId(int id)
        {
            IEnumerable<LotVaccin> toFind = _dc.LotVaccins.Include("TypeVaccin").Where(c => c.CentreId == id);
            List<string> lotVaccins = new List<string>();

            foreach (var item in toFind)
            {
                lotVaccins.Add(item.TypeVaccin.Name);
            }

            return lotVaccins;      
        }

        public void Insert(LotVaccinForm form)
        {
            throw new NotImplementedException();
        }

        public void Update(LotVaccinForm form)
        {
            throw new NotImplementedException();
        }
    }
}

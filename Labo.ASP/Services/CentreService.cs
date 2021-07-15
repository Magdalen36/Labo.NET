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
    public class CentreService : IService<CentreModel, CentreForm>
    {
        private readonly DataContext _dc;

        public CentreService(DataContext dc)
        {
            _dc = dc;
        }

        public bool Delete(int d)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CentreModel> GetAll()
        {
            IEnumerable<Centre> centres = _dc.Centres.Include("Adress");
            return centres.Select(c => new CentreModel { Id = c.Id, Name = c.Name, AdressId = c.AdressId, ResponsableId = c.ResponsableId, Ville = c.Adress.Ville});
        }

        public CentreForm GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CentreForm form)
        {
            throw new NotImplementedException();
        }

        public void Update(CentreForm form)
        {
            throw new NotImplementedException();
        }
    }
}

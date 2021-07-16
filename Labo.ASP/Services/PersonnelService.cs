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
    public class PersonnelService : IService<PersonnelModel, PersonnelForm>
    {
        private readonly DataContext _dc;

        public PersonnelService(DataContext dc)
        {
            _dc = dc;
        }

        public string GetNomResponsableById(int id)
        {
            Personnel toFind = _dc.Personnels.Find(id);
            return toFind.FirstName + " " + toFind.LastName;
        }

        public bool Delete(int d)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonnelModel> GetAll()
        {
            IEnumerable<Personnel> personnels = _dc.Personnels.Include("Grade").Include("Centre");
            return personnels.Select(p => new PersonnelModel
            {
                Id = p.Id, 
                CentreId = p.CentreId, 
                FirstName = p.FirstName, 
                LastName = p.LastName, 
                Inami = p.Inami, 
                NomGrade = p.Grade.Name,
                NomCentre = p.Centre.Name
            });
        }

        public PersonnelForm GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(PersonnelForm form)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonnelForm form)
        {
            throw new NotImplementedException();
        }
    }
}

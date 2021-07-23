using Labo.ASP.Models;
using Labo.ASP.Models.Forms;
using Labo.ASP.Tools;
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
            IEnumerable<Personnel> personnels = _dc.Personnels.Include("Grade").Include("Centre").OrderBy(g => g.GradeId);
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
            Personnel toFind = _dc.Personnels.Find(id);

            string gradeName = "";
            

            if (toFind != null)
            {

                switch (toFind.GradeId)
                {
                    case 1: gradeName = "Médecin"; break;
                    case 2: gradeName = "Infirmier"; break;
                    case 3: gradeName = "Sécurité"; break;
                    case 4: gradeName = "Bénévole"; break;
                }

                return new PersonnelForm 
                {
                    Id = toFind.Id,
                    FirstName = toFind.FirstName,
                    LastName = toFind.LastName,
                    Inami = toFind.Inami,
                    GradeName = gradeName,
                    CentreId = toFind.CentreId,
                    //PasswordIn = toFind.Password,
                    Salt = toFind.Salt,
                };
            }
            else
            {
                return null;
            }
        }

        public void Insert(PersonnelForm form)
        {
            PersonnelModel model = new PersonnelModel()
            {
                FirstName = form.FirstName,
                LastName = form.LastName,
                Id = form.Id,
                Inami = form.Inami,
                PasswordIn = form.PasswordIn,
                CentreId = form.CentreId,
                GradeId = form.GradeId
            };

            Personnel entity = new Personnel()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = model.PasswordOut, 
                Inami = model.Inami,
                CentreId = model.CentreId,
                GradeId = model.GradeId
            };

            _dc.Personnels.Add(entity);
            _dc.SaveChanges();

            //PErmet de mettre l'id calculé par la db dans l'objet de départ (form)
            form.Id = entity.Id;
        }

        public void Update(PersonnelForm form)
        {
            throw new NotImplementedException();
        }

        public int Connect(ConnexionForm form)
        {
            Personnel toCheck = _dc.Personnels.Find(form.Id);
            bool coOk = false; int centreId = 0;

            PasswordHash ph = new PasswordHash();
            byte[] pwd = ph.HashMe(form.Password);

            //check password

            for (int i = 0; i < (toCheck.Password.Length); i++)
            {
                if (toCheck.Password[i] == pwd[i])
                {
                    coOk = true;
                }
                else return 0;                
            }
 
            if(coOk == true) { centreId = toCheck.CentreId; }
            return centreId;
        
        }
    }
}

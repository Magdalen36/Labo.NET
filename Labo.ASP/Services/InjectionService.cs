using Labo.ASP.Models;
using Labo.ASP.Models.Forms;
using Labo.DAL;
using Labo.DAL.Entities;
using Labo.ASP.Tools;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Labo.ASP.Services
{
    public class InjectionService : IService<InjectionModel, InjectionForm>
    {
        private readonly DataContext _dc;

        public InjectionService(DataContext dc)
        {
            _dc = dc;
        }
    
        public bool Delete(int d)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InjectionModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Injection> GetAllByPatientId(int id)
        {
            IEnumerable<Injection> injections = _dc.Injections.Where(i => i.PatientId == id);
            return injections;
        }

        public InjectionForm GetById(int id) //Par l'id de l'injection (fournie lors de l'inscription)
        {
            Injection toFind = _dc.Injections.SingleOrDefault(p => p.Id == id);
            Patient patient = _dc.Patients.Find(toFind.PatientId);
            string patientName = patient.FirstName + " " + patient.LastName;  
            
            CalendrierHeure ch = _dc.CalendrierHeures.Find(toFind.CalendrierHeureId);
            CalendrierJour cc = _dc.CalendrierJours.Find(ch.CalendrierJourId);
            DateTime cal = cc.Day;

            Personnel personnel = _dc.Personnels.Find(toFind.PersonnelId);
            string personnelName = "";
            if (personnel != null)
                personnelName = personnel.FirstName + " " + personnel.LastName;

            if (toFind != null)
            {
                return new InjectionForm
                {
                    Id = toFind.Id,
                    CalendrierHeureId = toFind.Id,
                    LotVaccinId = toFind.LotVaccinId,
                    PatientId = toFind.PatientId,
                    PersonnelId = toFind.PersonnelId,
                    PatientName = patientName,
                    PersonnelName = personnelName,
                    CalendrierJour = cal
                };
            }
            else
            {
                return null;
            }

        }

        public void Insert(InjectionForm form)
        {
            throw new NotImplementedException();
        }

        public void Update(InjectionForm form, int personnelId)
        {
            Injection i = _dc.Injections.Find(form.Id);
            i.LotVaccinId = form.LotVaccinId;
            i.PersonnelId = personnelId;

            _dc.SaveChanges();
        }

        public void Update(InjectionForm form)
        {
            throw new NotImplementedException();
        }
    }
}

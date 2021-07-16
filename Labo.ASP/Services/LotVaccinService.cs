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
        private readonly IService<AdressModel, AdressForm> _serviceAdress;

        public LotVaccinService(DataContext dc, IService<AdressModel, AdressForm> sa)
        {
            _dc = dc;
            _serviceAdress = sa;
        }

        public bool Delete(int d)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StockVaccinModel> GetAll()
        {
            IEnumerable<LotVaccin> lotVaccins = _dc.LotVaccins.Include(f => f.Fournisseur)
                                                                       .ThenInclude(a => a.Adress)
                                                              .Include(t => t.TypeVaccin);

            return lotVaccins.Select(l => new StockVaccinModel()
            {
                Id = l.Id,
                QuantiteEntree = l.QuantiteEntree,
                DateEntree = l.DateEntree,
                QuantiteRestante = l.QuantiteRestante,
                DateSortie = l.DateSortie,
                NameFournisseur = l.Fournisseur.FirstName + " " + l.Fournisseur.LastName,
                NameTypeVaccin = l.TypeVaccin.Name,
                CentreId = l.CentreId,
                NomRueF = l.Fournisseur.Adress.NomRue,               
                NumRueF = l.Fournisseur.Adress.NumRue,               
                CodePostalF = l.Fournisseur.Adress.CodePostal,               
                VilleF = l.Fournisseur.Adress.Ville,   
                PaysF = l.Fournisseur.Adress.Pays
            }); 
        }

        public IEnumerable<StockVaccinModel> GetAllByCentre(int id)
        {
            IEnumerable<StockVaccinModel> lotVaccins = GetAll().Where(l => l.CentreId == id);
            return lotVaccins;
        }

        public LotVaccinForm GetById(int id)
        {
            throw new NotImplementedException();
        }

        //Pour l'affichage visiteur, retour des noms de vaccins selon le centre choisi
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

        IEnumerable<LotVaccinModel> IService<LotVaccinModel, LotVaccinForm>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

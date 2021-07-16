using Labo.ASP.Models;
using Labo.ASP.Models.Forms;
using Labo.DAL;
using Labo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Services
{
    public class HeureOuvertureService : IService<HeureOuvertureModel, HeureOuvertureForm>
    {
        private readonly DataContext _dc;

        public HeureOuvertureService(DataContext dc)
        {
            _dc = dc;
        }

        public bool Delete(int d)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HeureOuvertureModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public HeureOuvertureForm GetById(int id)
        {
            HeureOuverture toFind = _dc.HeureOuvertures.Find(id);
            if (toFind != null)
            {
                return new HeureOuvertureForm
                {
                    Id = toFind.Id,
                    HeureDebut = toFind.HeureDebut,
                    HeureFin = toFind.HeureFin,
                    Jour = toFind.Jour
                };
            }
            else return null;
        }

        public Dictionary<string, string> GetByCentreId(int id)
        {
            Dictionary<string,string> heures = new Dictionary<string, string>(); 
            string jour = "";

            IEnumerable<HeureOuverture> toFind = _dc.HeureOuvertures.Where(c => c.CentreId == id);            
            
            foreach (var item in toFind)
                {
                    switch (item.Jour)
                    {
                        case 1: jour = "Lundi"; break;
                        case 2: jour = "Mardi"; break;
                        case 3: jour = "Mercredi"; break;
                        case 4: jour = "Jeudi"; break;
                        case 5: jour = "Vendredi"; break;
                        case 6: jour = "Samedi"; break;
                        case 7: jour = "Dimanche"; break;
                    }

                    heures.Add(jour, "De " + item.HeureDebut + "h à " + item.HeureFin + "h ");
                }
            return heures;
        }

        public void Insert(HeureOuvertureForm form)
        {
            throw new NotImplementedException();
        }

        public void Update(HeureOuvertureForm form)
        {
            throw new NotImplementedException();
        }
    }
}

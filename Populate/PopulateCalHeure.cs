using Labo.DAL;
using Labo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populate
{
    public class PopulateCalHeure
    {

        public void InsertCalendar(DataContext _dc)
        {

            DataContext _dc2 = new DataContext();

            IEnumerable<CalendrierJour> calendrierJours = _dc.CalendrierJours.Include(c => c.Centre).ThenInclude(h => h.HeureOuvertures);
            int cpt = 0; //pour l'id

            foreach (var jour in calendrierJours)
            {

                //Aller rechercher les heures d'ouverture correspondant au centre et au bon jour de la semaine
                HeureOuverture ho = jour.Centre.HeureOuvertures.Where(h => h.Jour == (int)jour.Day.DayOfWeek).FirstOrDefault();
               
                if(ho != null)
                {
                    int heureDebut = ho.HeureDebut;
                    int heureFin = ho.HeureFin - 1;

                    //Pour remplir chaque heure correspondant aux heures d'ouvertures 
                    for (int i = heureDebut; i <= heureFin; i++)
                    {
                        //pour remplir chaque créneau horaire //0 : heure pile ; 1 : 15 ; 2 : 30 ; 3 : 45
                        for (int j = 0; j < 4; j++)
                        {
                            CalendrierHeure ch = new CalendrierHeure
                            {
                                //Id = cpt,
                                Heure = i,
                                Time = j,
                                CalendrierJourId = jour.Id
                            };

                            _dc2.CalendrierHeures.Add(ch);
                            _dc2.SaveChanges();
                        }
                    }

                    cpt++; Console.WriteLine(cpt);
                }
                
                
            }
        }
    }
}

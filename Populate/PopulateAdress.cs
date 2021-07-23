using Labo.ASP.Models;
using Labo.ASP.Services;
using Labo.DAL;
using Labo.DAL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Populate
{
    public class PopulateAdress
    {

        public void InsertRandomUser(int i)
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = client.GetAsync("https://randomuser.me/api/?nat=fr").Result;
                string json = message.Content.ReadAsStringAsync().Result;
                RandomUserModel model = JsonConvert.DeserializeObject<RandomUserModel>(json);

                Adress am = new Adress
                {
                    //Id = i,
                    NomRue = model.Results[0].Location.Street.Name,
                    NumRue = (model.Results[0].Location.Street.Number).ToString(),
                    Ville = model.Results[0].Location.City,
                    CodePostal = model.Results[0].Location.Postcode,
                    Pays = model.Results[0].Location.Country
                };

                DataContext dc = new DataContext(); 
                dc.Adresses.Add(am);
                dc.SaveChanges();
            }
        }
    }
}

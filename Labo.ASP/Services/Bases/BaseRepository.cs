using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Services.Bases
{
    public class BaseRepository
    {
        protected readonly Uri baseAddress = new Uri("http://localhost:44371/api/");
        protected readonly string route;

        public BaseRepository(string route)
        {
            this.route = route;
        }

    //    using (HttpClient client = new HttpClient())
    //        {
    //            HttpResponseMessage message = client.GetAsync("https://randomuser.me/api/?nat=fr").Result;
    //string json = message.Content.ReadAsStringAsync().Result;
    //RandomUserModel model = JsonConvert.DeserializeObject<RandomUserModel>(json);

    //Adress am = new Adress
    //{
    //    //Id = i,
    //    NomRue = model.Results[0].Location.Street.Name,
    //    NumRue = (model.Results[0].Location.Street.Number).ToString(),
    //    Ville = model.Results[0].Location.City,
    //    CodePostal = model.Results[0].Location.Postcode,
    //    Pays = model.Results[0].Location.Country
    //};

    //DataContext dc = new DataContext();
    //dc.Adresses.Add(am);
    //            dc.SaveChanges();
    //        }
    }
   
}

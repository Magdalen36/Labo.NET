using Labo.ASP.Models;
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
    public class PopulatePatient
    {
        public void InsertRandomUser()
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = client.GetAsync("https://randomuser.me/api/?nat=fr").Result;
                string json = message.Content.ReadAsStringAsync().Result;
                RandomUserModel model = JsonConvert.DeserializeObject<RandomUserModel>(json);

                Random rand = new Random();
                string indicationsMedicales = "";

                //Gestion password
                string PasswordIn = model.Results[0].Login.Password;
                PasswordHash ph = new PasswordHash();

                //Registre National
                string rn = rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10);
                //Telephone
                string tel = rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10);



                if ((rand.Next(0, 2) == 0))
                {
                    //Indications médicales
                    indicationsMedicales = "blabla";
                }

                Patient am = new Patient
                {
                    FirstName = model.Results[0].Name.First,
                    LastName = model.Results[0].Name.Last,
                    Salt = model.Results[0].Login.Salt,
                    Password = ph.HashMe(PasswordIn),
                    BirthDate = model.Results[0].Dob.Date.DateTime, //Gestion de date DateTimeOffset => DateTime
                    RegistreNat = rn,
                    Mail = model.Results[0].Email,
                    IndicMed = indicationsMedicales,                   
                    PhoneNumber = long.Parse(tel),
                    AdressId = rand.Next(0,200)
                };

                DataContext dc = new DataContext();
                dc.Patients.Add(am);
                dc.SaveChanges();
            }



        }
    }
}

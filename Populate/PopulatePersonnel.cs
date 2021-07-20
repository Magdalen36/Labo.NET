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
    public class PopulatePersonnel
    { 

        public void InsertRandomUser()
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = client.GetAsync("https://randomuser.me/api/?nat=fr").Result;
                string json = message.Content.ReadAsStringAsync().Result;
                RandomUserModel model = JsonConvert.DeserializeObject<RandomUserModel>(json);

                Random rand = new Random();
                long inami = 0; int gradeMin = 3; int gradeMax = 5; 

                //Gestion password
                string PasswordIn = model.Results[0].Login.Password;
                PasswordHash ph = new PasswordHash();


                if ((rand.Next(0,2) == 0)) 
                {
                    //Inami
                    string temp = rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10) + "" + rand.Next(10);
                    inami = long.Parse(temp);
                    gradeMin = 1;
                    gradeMax = 3;
                }

                Personnel am = new Personnel
                {
                    FirstName = model.Results[0].Name.First,
                    LastName = model.Results[0].Name.Last,
                    Salt = model.Results[0].Login.Salt,
                    CentreId = rand.Next(1, 4),
                    GradeId = rand.Next(gradeMin, gradeMax), //ATTENTION INAMI UNIQUEMENT SUR GRADE 1 et 2
                    Inami = inami,
                    Password = ph.HashMe(PasswordIn)
                };

                DataContext dc = new DataContext();
                dc.Personnels.Add(am);
                dc.SaveChanges();
            }



        }
    }
}

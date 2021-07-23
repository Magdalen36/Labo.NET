using Labo.ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Labo.ASP.ViewComponents
{
    public class RandomUserViewComponent: ViewComponent
    {

        //private readonly string url = "https://randomuser.me/api";

        //public IViewComponentResult Invoke()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpResponseMessage message = client.GetAsync(url).Result;
        //        string json = message.Content.ReadAsStringAsync().Result;
        //        RandomUserModel model = JsonConvert.DeserializeObject<RandomUserModel>(json);
        //        return View(model);
        //    }           
        //} 
    }
}

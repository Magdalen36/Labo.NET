using Labo.ASP.Models;
using Labo.ASP.Models.Forms;
using Labo.ASP.Services;
using Labo.ASP.Tools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Controllers
{
    public class LotVaccinController : Controller
    {

        private readonly IService<LotVaccinModel, LotVaccinForm> _serviceLotVaccin;
        private readonly IService<AdressModel, AdressForm> _serviceAdress;

        public LotVaccinController(IService<LotVaccinModel, LotVaccinForm> sl, IService<AdressModel, AdressForm> sa)
        {
            _serviceLotVaccin = sl;
            _serviceAdress = sa;
        }

        public IActionResult Index()
        {
            TempData["isLogged"] = HttpContext.Session.Get<bool>("IsLogged");
            return View();
        }

        public IActionResult ListeVaccinCentre([FromRoute] int id)
        {
            IEnumerable<StockVaccinModel> model = (_serviceLotVaccin as LotVaccinService).GetAllByCentre(id);
           
            return View(model);
        }


    }
}

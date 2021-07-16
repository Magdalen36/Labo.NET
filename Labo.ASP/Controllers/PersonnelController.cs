using Labo.ASP.Models;
using Labo.ASP.Models.Forms;
using Labo.ASP.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo.ASP.Controllers
{
    public class PersonnelController : Controller
    {

        private readonly IService<PersonnelModel, PersonnelForm> _servicePersonnel;

        public PersonnelController(IService<PersonnelModel, PersonnelForm> sp)
        {
            _servicePersonnel = sp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListePersonnelCentre([FromRoute] int id)
        {
            IEnumerable<PersonnelModel> model = _servicePersonnel.GetAll();
            IEnumerable<PersonnelModel> modelCentre = model.Where(m => m.CentreId == id);

            return View(modelCentre);
        }
    }
}

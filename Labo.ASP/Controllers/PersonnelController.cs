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

        public IActionResult Connexion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Connexion(ConnexionForm form)
        {

            if (ModelState.IsValid)
            {
                int centreId = (_servicePersonnel as PersonnelService).Connect(form);

                if(centreId != 0)
                {
                    HttpContext.Session.Set<bool>("IsLogged", true);
                    HttpContext.Session.Set<int>("UserId", form.Id);
                    return RedirectToAction("ListePersonnelCentre", "Personnel", new { id = centreId });
                }
                else
                {
                    TempData["error"] = "Identifiant ou mot de passe invalide";
                    return View(form);
                }
            }
            else
            {
                TempData["error"] = "formulaire invalide";
                return View(form);
            }
        }


        public IActionResult ListePersonnelCentre([FromRoute] int id)
        {
            IEnumerable<PersonnelModel> model = _servicePersonnel.GetAll();
            IEnumerable<PersonnelModel> modelCentre = model.Where(m => m.CentreId == id);

            return View(modelCentre);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonnelForm form)
        {
            if (ModelState.IsValid)
            {
                _servicePersonnel.Insert(form);
                HttpContext.Session.Set<int>("UserId", form.Id);
                //TempData["succes"] = "Insertion effectuée";
                //HttpContext.Session.Set<bool>("IsLogged", true);


                return RedirectToAction("Personnel", "ListePersonnelCentre");
            }
            else
            {
                TempData["error"] = "Formulaire invalide";
                return View(form);
            }
        }

    }
}

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
        private readonly IService<InjectionModel, InjectionForm> _serviceInjection;

        public PersonnelController(IService<PersonnelModel, PersonnelForm> sp , IService<InjectionModel, InjectionForm> s)
        {
            _servicePersonnel = sp;
            _serviceInjection = s;
        }

        public IActionResult Index()
        {
            TempData["isLogged"] = HttpContext.Session.Get<bool>("IsLogged");

            PersonnelForm form = _servicePersonnel.GetById(HttpContext.Session.Get<int>("UserId"));
            return View(form);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Set<bool>("IsLogged", false);
            return RedirectToAction("Index", "Home");
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
                    HttpContext.Session.Set<int>("CentreId", centreId);
                    //return RedirectToAction("ListePersonnelCentre", new { id = centreId });
                    return RedirectToAction("Index", new { id = form.Id });
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


        public IActionResult ListePersonnelCentre()
        {
            TempData["isLogged"] = HttpContext.Session.Get<bool>("IsLogged");

            IEnumerable<PersonnelModel> model = _servicePersonnel.GetAll();
            IEnumerable<PersonnelModel> modelCentre = model.Where(m => m.CentreId == HttpContext.Session.Get<int>("CentreId"));

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
                TempData["succes"] = "Insertion effectuée";
                //HttpContext.Session.Set<bool>("IsLogged", true);


                return RedirectToAction("Connexion", "Personnel");
            }
            else
            {
                TempData["error"] = "Formulaire invalide";
                return View(form);
            }
        }

        public IActionResult GetInjection(int id) {

            TempData["isLogged"] = HttpContext.Session.Get<bool>("IsLogged");

            InjectionForm form = _serviceInjection.GetById(id);
            return View(form);
        }

    }
}

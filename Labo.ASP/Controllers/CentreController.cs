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
    public class CentreController : Controller
    {
        private readonly IService<CentreModel, CentreForm> _serviceCentre;
        private readonly IService<AdressModel, AdressForm> _serviceAdress;
        private readonly IService<PersonnelModel, PersonnelForm> _servicePersonnel;
        private readonly IService<HeureOuvertureModel, HeureOuvertureForm> _serviceHeureOuverture;
        private readonly IService<LotVaccinModel, LotVaccinForm> _serviceLotVaccin;

        public CentreController(
            IService<CentreModel, CentreForm> sc,
            IService<AdressModel, AdressForm> sa,
            IService<PersonnelModel, PersonnelForm> sp,
            IService<HeureOuvertureModel, HeureOuvertureForm> sh,
            IService<LotVaccinModel, LotVaccinForm> sl
            )
        {
            _serviceCentre = sc;
            _serviceAdress = sa;
            _servicePersonnel = sp;
            _serviceHeureOuverture = sh;
            _serviceLotVaccin = sl;
        }

        public IActionResult Index()
        {
            TempData["isLogged"] = HttpContext.Session.Get<bool>("IsLogged");
            IEnumerable<CentreModel> model = _serviceCentre.GetAll();
            return View(model);
        }

        public IActionResult Detail([FromRoute] int id)
        {
            DetailCentreModel model = new DetailCentreModel();

            model.TypeVaccin = (_serviceLotVaccin as LotVaccinService).GetByCentreId(id);

            model.HeuresOuverture = (_serviceHeureOuverture as HeureOuvertureService).GetByCentreId(id);
            model.NameR = (_servicePersonnel as PersonnelService).GetNomResponsableById(id);
            
            AdressForm modelAdress = _serviceAdress.GetById(id);
            model.NomRue = modelAdress.NomRue;
            model.NumRue = modelAdress.NumRue;
            model.Ville = modelAdress.Ville;
            model.CodePostal = modelAdress.CodePostal;
            model.Pays = modelAdress.Pays;

            return View(model);
        }
    }
}

using DemoMVC.Models;
using DemoMVC.Models.PersonViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        private static List<PersonViewModel> people = [
                new PersonViewModel { Firstname = "Dipper", Lastname = "Pines"},
                new PersonViewModel {Firstname = "Mabel", Lastname = "Pines"},
                new PersonViewModel {Firstname = "Bill", Lastname= "Cypher"}
            ];

        private static MonumentViewModel monument = new MonumentViewModel { Nom = "Tour eifel" };

        public IActionResult Index()
        {
            // Objet "ViewData" permet de passer des données du contrôleur à la vue
            ViewData["date"] = DateTime.Today;
            ViewData["nb"] = 42;

            // Génération de la vue
            DemoIndexViewModel model = new DemoIndexViewModel() { people = people, monument= monument };
            return View(model);
        }

        public IActionResult OldRoute()
        {
            //return RedirectToActionPermanent("CurrentRoute"); // éviter le text hard-coder avec nameof()
            return RedirectToActionPermanent(nameof(CurrentRoute));
        }

        public IActionResult CurrentRoute()
        {
            return View();
        }
    }
}

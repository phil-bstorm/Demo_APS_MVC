using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            // Objet "ViewData" permet de passer des données du contrôleur à la vue
            ViewData["date"] = DateTime.Today;
            ViewData["nb"] = 42;

            // Génération de la vue

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

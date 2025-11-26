using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Example(string slug)
        {
            Console.WriteLine("Blog> " + slug);
            return View();
        }
    }
}

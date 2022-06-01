using Microsoft.AspNetCore.Mvc;

namespace Corsework.Controllers
{
    public class HomeController : Controller
    {
        /* Index.cshtml - default */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Show(int id)
        {
            if (id < 0)
            {
                return BadRequest("Id cannot be negative");
            }
            if (id == 1)
            {
                return View("Show", id);
            }
            return NotFound();
        }

        public IActionResult Show_v2()
        {
            return View("Show", new Data.Models.CsModels.Components.Motherboard());
        }
    }
}

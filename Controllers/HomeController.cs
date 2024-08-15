using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionCursos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

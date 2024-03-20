using Microsoft.AspNetCore.Mvc;

namespace ProjetoSiteAcademia.Controllers
{
    public class TreinosController : Controller
    {
        public IActionResult TreinoA()
        {
            return View();
        }
        public IActionResult TreinoB()
        {
            return View();
        }
        public IActionResult TreinoC()
        {
            return View();
        }
    }
}

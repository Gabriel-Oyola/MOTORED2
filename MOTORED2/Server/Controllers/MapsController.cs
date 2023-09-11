using Microsoft.AspNetCore.Mvc;

namespace MOTORED2.Server.Controllers
{
    public class MapsController : Controller
    {
        public IActionResult Mapa()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MOTORED2.Server.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ClaimsPrincipal claimsuser = HttpContext.User;
            string nombreUsuario = "";
            if (claimsuser.Identity.IsAuthenticated)
            {
                nombreUsuario = claimsuser.Claims.Where(c=>c.Type==ClaimTypes.Name).Select(c=>c.Value).FirstOrDefault();
            }

            ViewData["nombreUsuario"] = nombreUsuario; 

            return View();
        }

        public async Task <IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("IniciarSesion", "Inicio");
        }
    }

   


}

using Microsoft.AspNetCore.Mvc;
using MOTORED2.Server.Models;
using MOTORED2.Server.Recursos;
using MOTORED2.Server.Servicios.Contrato;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace MOTORED2.Server.Controllers
{
    public class InicioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public InicioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Registrarse() //Tipo GET, ESTE METODO VA DEVOLVER LA LISTA
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Registrarse(Usuario modelo) //TIPO POST,  ESTE METODO VA RESPONDER LA SOLICITUD 
        {
            modelo.Clave = Utilidades.EncriptarClave(modelo.Clave); //pasamos la clave que tenemos en modelo,
                                                                    //luego la encriptamos con el metodo y la actualizamos 

            Usuario usuario_creado = await _usuarioService.SaveUsuario(modelo); //creamos un usuarioy lo guardamos 

            if (usuario_creado.IdUsuario > 0)
            {
                return RedirectToAction("IniciarSesion", "Inicio"); //En caso que el usuario se haya creado con exito
                                                                    //se retornara a la vista de login 

            }
            else
            {
                ViewData["Mensaje"] = "No se pudo crear el usuario";
                return View();
            }
            
        }

      
        public IActionResult IniciarSesion()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> IniciarSesion(string correo, string clave)
        {
            Usuario usuario_encontrado = await _usuarioService.GetUsuario(correo, Utilidades.EncriptarClave(clave)); 
            //Nos devolvera un Usuario
            //con su correo y clave encriptada

            if(usuario_encontrado==null) {
                ViewData["Mensaje"] = "No se encontraron coincidencias";
                return View();
            }//Se realiza validacion si no se encontro el usuario 

            //creamos un objeto que pueda almacenar la informacion de nuestro usuario 
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, usuario_encontrado.NombreUsuario)
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            //Registramos el claims con una estructura por defecto 

            //Creamos las propiedades de autenticacion 
            AuthenticationProperties properties = new AuthenticationProperties()
            {
                AllowRefresh= true
            };

            //Registramos como iniciado sesion al usuario
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                properties
                );


            return RedirectToAction("Index", "Home"); 
        }


    }
}

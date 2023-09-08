using Microsoft.EntityFrameworkCore;
using MOTORED2.Server.Models;
using MOTORED2.Server.Servicios.Contrato;

namespace MOTORED2.Server.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService //Agregamos la herencia de la interfaz 
    {
        private readonly MotoredContext _motoredContext; //Creamos una variable que hace referencia a nuestra base de datos 

        public UsuarioService(MotoredContext motoredContext) //Constructor y le pasamos como parametro nuestro contexto 
        {
            _motoredContext = motoredContext;
        }

        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario_encontrado = await _motoredContext.Usuarios.Where(u => u.Correo == correo && u.Clave== clave).FirstOrDefaultAsync();
            return usuario_encontrado; 

            //Se realiza busqueda del usuario y se lo devuelve 
        }

        public async Task<Usuario> SaveUsuario(Usuario Modelo)
        {
           _motoredContext.Usuarios.Add(Modelo);//Agregamos modelo a la tabla
            await _motoredContext.SaveChangesAsync();//Guardamos cambios
            return Modelo; 

            
        }
    }
}

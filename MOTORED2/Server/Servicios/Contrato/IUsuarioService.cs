using Microsoft.EntityFrameworkCore;
using MOTORED2.Server.Models; 



namespace MOTORED2.Server.Servicios.Contrato
{
    public interface IUsuarioService
    {

        //Aqui declararemos los metodos que vamos utilizar 

        Task<Usuario> GetUsuario(string correo, string clave); //Devolveremos un usuario

        Task<Usuario> SaveUsuario(Usuario Modelo); //Guardaremos un Usuario

    }
}

using System.Security.Cryptography;
using System.Text; 




namespace MOTORED2.Server.Recursos
{
    public class Utilidades
    {
        public static string EncriptarClave (string clave)
        {
            StringBuilder sb = new StringBuilder ();
            using (SHA256 hash = SHA256Managed.Create()) //este metodo nos va permitir encriptar la clave en formato SHA256
            {
                Encoding enc = Encoding.UTF8;//Esta es la codificacion que utilizamos 
                byte[] result = hash.ComputeHash(enc.GetBytes(clave)); //creamos un array y le pasamos la clave como parametro 

                foreach (byte b in result)
                {
                    sb.Append(b.ToString("x2")); //Aca concatenaremos el resultado de result y
                                                 //le decimos que la cadena debe formatearse en un valor hexadecimal
                }
            }
            return sb.ToString();  
        }
    }
}

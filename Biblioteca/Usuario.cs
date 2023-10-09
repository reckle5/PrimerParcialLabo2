using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        public string User { get; set; }
        public string Password { get; set; }

        public Usuario(string user, string password)
        {
            this.User = user;
            this.Password = password;
  
        }
     

        public bool LogIn(Usuario user, string usuario, string contraseña)
        {
            if (user.User.Equals(usuario) && user.Password.Equals(contraseña))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

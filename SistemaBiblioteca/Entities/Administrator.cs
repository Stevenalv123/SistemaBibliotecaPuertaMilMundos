using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Administrator
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Administrator(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

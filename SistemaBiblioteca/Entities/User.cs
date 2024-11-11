using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class User
    {
        public string Id_User {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string ID { get; set; }

        public User(string id_User, string name, string address, string phoneNumber, string email, string id)
        {
            Id_User = id_User;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            ID = id;
        }
    }
}

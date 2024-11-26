using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Student
    {
        public string Carnet {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string Carrer { get; set; }

        public Student(string carnet, string name, string address, string phoneNumber, string email, string carrer)
        {
            Carnet = carnet;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Carrer = carrer;
        }
    }
}

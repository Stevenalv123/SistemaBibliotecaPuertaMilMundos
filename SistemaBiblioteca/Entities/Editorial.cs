using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Editorial
    {
        public string Id_Editorial { get; set; }  
        public string Name { get; set; }  
        public string Adress { get; set; }
        public string Phone_Number { get; set; } 
        public string Email { get; set; }

        private static int counterEditorials = 1;
        public Editorial(string name, string adress, string phone_Number, string email)
        {
            Id_Editorial = GetId_Editorial();
            Name = name;
            Adress = adress;
            Phone_Number = phone_Number;
            Email = email;
        }

        private string GetId_Editorial()
        {
            return $"E{counterEditorials.ToString("D3")}";
        }

        private static void IncrementCounter()
        {
            counterEditorials++;
        }

        public static void InitializeCounter(int maxId)
        {
            counterEditorials = maxId + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Categorie
    {
        public string Id_Categorie { get; set; }
        public string Name { get; set; }

        public Categorie(string name)
        {
            Id_Categorie = GetId_Categorie();
            Name = name;
        }

        private int counterCategorie = 1;
        private string GetId_Categorie()
        {
            string id = $"C{counterCategorie.ToString("D3")}";
            IncrementCounter();
            return id;

        }

        private void IncrementCounter()
        {
            counterCategorie++;
        }
    }
}

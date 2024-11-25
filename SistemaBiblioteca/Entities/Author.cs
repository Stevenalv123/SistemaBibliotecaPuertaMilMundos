using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Author
    {
        public string Id_Author { get; set; }
        public string Name { get; set; }
        public string Nacionality { get; set; }
        public int Year_birth { get; set; }

        public Author(string name, string nacionality, int year_birth)
        {
            Id_Author = GetId_Author();
            Name = name;
            Nacionality = nacionality;
            Year_birth = year_birth;
        }


        private int counterAuthor = 1;
        private string GetId_Author()
        {
            return $"A{counterAuthor.ToString("D3")}";
        }

        private void IncrementCounter()
        {
            counterAuthor++;
        }
    }
}

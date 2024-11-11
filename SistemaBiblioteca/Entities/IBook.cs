using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public interface IBook
    {
        public void AddBook();

        public void UpdateBook();

        public void DeleteBook();

        public void GetBook();

    }
}

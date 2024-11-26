using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public interface IBook
    {
        void AddBook(List<Book> books);

        void UpdateBook();

        void DeleteBook(List<Book> books);

        void GetBook();

    }
}

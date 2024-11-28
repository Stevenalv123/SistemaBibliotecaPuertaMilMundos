using SistemaBiblioteca.Forms.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBiblioteca.Forms;

namespace SistemaBiblioteca.Forms
{
    public partial class MainFormBooks : Form
    {
        //Carga la informacion en el data al abrir el formulario
        private void MainFormBooks_Load(object sender, EventArgs e)
        {
            LoadBooksFromFile();
            ShowBooksOnDataGridView();
        }

        //No hace nada :(
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //PrintDialogBooks.ShowDialog();
        }

        //Abre el formulario de agregar libro
        private void AddNewBook(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks(books);
            addBooks.ShowDialog();
            if (addBooks.DialogResult == DialogResult.OK)
            {
                SaveBooksToFile();
                ShowAlert();
                LoadBooksFromFile();
                ShowBooksOnDataGridView();
            }
        }

        //Atajos de teclado
        private void MainFormBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                AddNewBook(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                TxtSearch.Focus();
            }
        }

        //Busca la informacion en la lista y la carga en el data
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Book> filteredBooks = new List<Book>();
            string search = TxtSearch.Text.Trim().ToLower();
            filteredBooks = books.Where(a => a.Title.ToLower().Contains(search)
                              || a.ISBN.ToLower().Contains(search)
                              || a.Author.ToLower().Contains(search)
                              || a.YearPublication.ToString().Contains(search)).ToList();
            UpdateBookData(filteredBooks);
        }

        //Actualizar los libros en el data
        private void UpdateBookData(List<Book> booksToShow)
        {
            DtvBooks.Rows.Clear();
            foreach (Book book in booksToShow.OrderBy(a => a.Title))
            {
                DtvBooks.Rows.Add(book.Title, book.Author, book.Categorie.Name, book.ISBN, book.Editorial.Name, book.YearPublication, book.Stock, book.BookState, book.Pages);
            }
        }
    }
}

using SistemaBiblioteca.Entities;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms
{
    public partial class MainFormBooks : Form
    {
        List<Book> books;
        public MainFormBooks()
        {
            InitializeComponent();
            books = new List<Book>();
        }

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

        private void UpdateBookData(List<Book> booksToShow)
        {
            DtvBooks.Rows.Clear();
            foreach (Book book in booksToShow.OrderBy(a => a.Title))
            {
                DtvBooks.Rows.Add(book.Title, book.Author, book.Categorie.Name, book.ISBN, book.Editorial.Name, book.YearPublication,book.Stock,book.BookState,book.Pages);
            }
        }
    }
}
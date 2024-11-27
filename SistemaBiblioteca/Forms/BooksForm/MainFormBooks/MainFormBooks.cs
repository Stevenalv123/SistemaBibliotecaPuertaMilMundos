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
            if(e.Control && e.KeyCode == Keys.L)
            {
                TxtSearch.Focus();
            }
        }
    }
}
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
    }
}
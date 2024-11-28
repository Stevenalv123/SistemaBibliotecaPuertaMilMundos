using SistemaBiblioteca.Forms;
using SistemaBiblioteca.Forms.DevolutionsForms;


namespace SistemaBiblioteca
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Login login = new Login();
            login.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowDevolutions(sender, e);
        }
    }
}

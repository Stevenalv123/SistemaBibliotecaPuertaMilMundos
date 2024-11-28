using SistemaBiblioteca.Forms;
using SistemaBiblioteca.Forms.AdminsForms;
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

        private async void BtnAdmins_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(AdminstratorsForms))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new AdminstratorsForms());
        }
    }
}

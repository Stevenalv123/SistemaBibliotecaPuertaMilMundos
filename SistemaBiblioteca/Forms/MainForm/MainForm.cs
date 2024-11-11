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

        private async void ShowDevolutions(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(DevolutionForm))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new DevolutionForm());
        }
    }
}

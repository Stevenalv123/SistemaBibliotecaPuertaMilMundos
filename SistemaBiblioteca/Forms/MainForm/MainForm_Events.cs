using SistemaBiblioteca.Forms;
using SistemaBiblioteca.Forms.AdminsForms;
using SistemaBiblioteca.Forms.DevolutionsForms;
namespace SistemaBiblioteca
{
    public partial class MainForm:Form
    {
        //Abrir el formulario de usuarios
        private async void ShowUsers(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(MainFormStudents))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new MainFormStudents());
        }

        //Abrir el formulario de libros
        private async void ShowBooks(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(MainFormBooks))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new MainFormBooks());
        }

        //Abrir el formulario de devoluciones y prestamos
        private async void ShowDevolutions(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(DevolutionForm))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new DevolutionForm());
        }

        //Salir
        private void Exit(object sender, FormClosingEventArgs e)
        {
            ExitForm exit = new ExitForm();
            DialogResult result = exit.ShowDialog();
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        //Abrir por default el form de devoluciones al cargar el formulario
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowDevolutions(sender, e);
        }

        //Abrir el formulario de administradores
        private async void BtnAdmins_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(AdminstratorsForms))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new AdminstratorsForms());
        }
    }
}

using SistemaBiblioteca.Forms;
using SistemaBiblioteca.Forms.DevolutionsForms;
namespace SistemaBiblioteca
{
    public partial class MainForm:Form
    {
        private async void ShowUsers(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(MainFormStudents))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new MainFormStudents());
        }

        private async void ShowBooks(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(MainFormBooks))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new MainFormBooks());
        }

        private async void ShowDevolutions(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(DevolutionForm))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new DevolutionForm());
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            ExitForm exit = new ExitForm();
            DialogResult result = exit.ShowDialog();
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}

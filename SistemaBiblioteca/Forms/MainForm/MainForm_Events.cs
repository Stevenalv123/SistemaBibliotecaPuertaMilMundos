using SistemaBiblioteca.Forms;
namespace SistemaBiblioteca
{
    public partial class MainForm:Form
    {
        // Open the form of users
        private async void ShowUsers(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(UserForm))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new UserForm());
        }

        // Open the form of books
        private async void ShowBooks(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(MainFormBooks))) return;
            OpenForm(new LoadingForm());
            await Task.Run(() => ShowLoading());
            OpenForm(new MainFormBooks());
        }

        // Shows a dialog to confirm the exit of the program
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

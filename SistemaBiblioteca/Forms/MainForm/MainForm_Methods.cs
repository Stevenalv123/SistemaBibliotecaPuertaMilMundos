namespace SistemaBiblioteca
{
    public partial class MainForm : Form
    {
        private Form ActiveForm;
        // Open the form and close the current one
        private void OpenForm(Form ChildForm)
        {
            if (ActiveForm != null) ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(ChildForm);
            MainPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        //Show a loading screen
        private void ShowLoading()
        {
            Thread.Sleep(2000);
        }

        //Check if the form is already open
        private bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

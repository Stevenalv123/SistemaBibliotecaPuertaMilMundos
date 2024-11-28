using SistemaBiblioteca.Forms.DevolutionsForms;
using SistemaBiblioteca.Forms;

namespace SistemaBiblioteca
{
    public partial class MainForm : Form
    {
        //Metodo para abrir formularios
        private Form ActiveForm;
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

        //Mostrar pantalla de carga
        private void ShowLoading()
        {
            Thread.Sleep(2000);
        }

        //Validar si ya esta abierto el formulario para no volverlo a abrirlo
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

using SistemaBiblioteca.Entities;

namespace SistemaBiblioteca.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator("Admin", "123");

            if (ValidateFields())
            {
                ValidateCredentials(administrator);
            }

            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidateFields()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(TxtUserName.Text))
            {
                LblErrorPassword.Visible = false;
                LblErrorUserName.Text = "Porfavor, rellene este campo.";
                LblErrorUserName.Visible = true;
                isValid = false;
            }
            else
            {
                LblErrorUserName.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                LblErrorUserName.Visible = false;
                LblErrorPassword.Text = "Porfavor, rellene este campo.";
                LblErrorPassword.Visible = true;
                isValid = false;
            }
            else
            {
                LblErrorPassword.Visible = false;
            }
            return isValid;
        }

        private void ValidateCredentials(Administrator administrator)
        {
            string username=TxtUserName.Text;
            string password=TxtPassword.Text;
            if (username == administrator.Username && password==administrator.Password)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
            else if(username == administrator.Username && password != administrator.Password)
            {
                LblErrorPassword.Visible=false;
                LblErrorPassword.Text = "La contraseña es incorrecta";
                LblErrorPassword.Visible = true;
            }else if(username != administrator.Username)
            {
                LblErrorUserName.Visible=false;
                LblErrorUserName.Text = "El username no existe";
                LblErrorUserName.Visible = true;
            }
            
        }
    }
}

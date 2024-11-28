using SistemaBiblioteca.Entities;

namespace SistemaBiblioteca.Forms
{
    public partial class Login : Form
    {
        List<Administrator> administrators;
        public Login()
        {
            InitializeComponent();
            administrators = new List<Administrator>();
        }

        //Continuar si es correcta la info
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                ValidateCredentials();
            }
        }

        //Cerrar
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Validar los campos
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

        //Validar la informacion a ver si es correcta
        private void ValidateCredentials()
        {
            string username=TxtUserName.Text;
            string password=TxtPassword.Text;

            administrators = LoadChanges();

            foreach (var admin in administrators)
            {
                if (username == admin.Username && password == admin.Password)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else if (username == admin.Username && password != admin.Password)
                {
                    LblErrorPassword.Visible = false;
                    LblErrorPassword.Text = "La contraseña es incorrecta";
                    LblErrorPassword.Visible = true;
                }
                else if (username != admin.Username)
                {
                    LblErrorUserName.Visible = false;
                    LblErrorUserName.Text = "El username no existe";
                    LblErrorUserName.Visible = true;
                }
            }
        }

        //Cargar los administradores de archivos
        public List<Administrator> LoadChanges()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaAdministradores.txt");

            if (administrators != null)
            {
                administrators.Clear();
            }

            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath)) 
                    {
                        writer.WriteLine($"Admin,123");
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los administradores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] datos = line.Split(',');

                        if (datos.Length == 2)
                        {
                            string username = datos[0];
                            string password = datos[1];

                            administrators.Add(new Administrator(username, password));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los administradores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return administrators;
        }
    }
}

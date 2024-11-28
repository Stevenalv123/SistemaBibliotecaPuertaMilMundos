using FontAwesome.Sharp;
using SistemaBiblioteca.Entities;

namespace SistemaBiblioteca.Forms.AdminsForms
{
    public partial class AdminstratorsForms : Form
    {
        List<Administrator> administrators;

        public AdminstratorsForms()
        {
            InitializeComponent();
            administrators = new List<Administrator>();
        }


        //Al cargar el form la lista de administrator toma el valor de LoadChanges cargado de archivos y se muestra en el Flow layout
        private void AdminstratorsForms_Load(object sender, EventArgs e)
        {
            administrators=LoadChanges();
            ShowAdminsOnFlowLayoutPanel();
        }


        //Mostrar la informacion en el flow
        private void ShowAdminsOnFlowLayoutPanel()
        {
            Color redColor = Color.FromArgb(185, 27, 33);
            Color blueColor = Color.FromArgb(40, 68, 131);
            FlpAdmins.Controls.Clear();

            foreach (var admin in administrators)
            {
                var cardPanel = new Panel
                {
                    Width = 250,
                    Height = 350,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                var coverPictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    Image = Properties.Resources.Administrador,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.None
                };

                var titleLabel = new Label
                {
                    Text = admin.Username,
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30
                };

                var categoryLabel = new Label
                {
                    Text = $"Contraseña: {admin.Password}",
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 25
                };


                var editButton = new IconButton
                {
                    IconChar = IconChar.Pencil,
                    IconColor = Color.White,
                    IconSize = 20,
                    ImageAlign = ContentAlignment.MiddleCenter,
                    Text = "",
                    Size = new Size(80, 60),
                    Dock = DockStyle.Right,
                    BackColor = blueColor,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Cursor = Cursors.Hand
                };

                var deleteButton = new IconButton
                {
                    IconChar = IconChar.Trash,
                    IconColor = Color.White,
                    IconSize = 20,
                    ImageAlign = ContentAlignment.MiddleCenter,
                    Text = "",
                    Size = new Size(80, 60),
                    Dock = DockStyle.Left,
                    BackColor = redColor,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Cursor = Cursors.Hand
                };

                var buttonPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 60,
                    Padding = new Padding(10),
                };

                buttonPanel.Controls.Add(editButton);
                buttonPanel.Controls.Add(deleteButton);

                deleteButton.Click += (s, e) =>
                {
                    var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este administrador?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        administrators.Remove(admin); 
                        SaveChanges(); 
                        ShowAdminsOnFlowLayoutPanel(); 
                    }
                };

                editButton.Click += (s, e) =>
                {
                    Register register = new Register(administrators, admin);
                    if (register.ShowDialog() == DialogResult.OK)
                    {
                        ShowAdminsOnFlowLayoutPanel();
                        SaveChanges();
                    }
                };

                cardPanel.Controls.Add(buttonPanel);
                cardPanel.Controls.Add(categoryLabel);
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(coverPictureBox);

                FlpAdmins.Controls.Add(cardPanel);
            }
        }

        //Evento para añadir un nuevo administrador
        private void TsbAddStudent_Click(object sender, EventArgs e)
        {
            Register register = new Register(administrators,null);
            if (register.ShowDialog() == DialogResult.OK)
            {
                SaveChanges();
                ShowAdminsOnFlowLayoutPanel();
            }
        }

        //Metodo para guardar los datos en archivos txt
        private void SaveChanges()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaAdministradores.txt");

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var admin in administrators)
                    {
                        writer.WriteLine($"{admin.Username},{admin.Password}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para cargar los datos de archivos
        public List<Administrator> LoadChanges()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaAdministradores.txt");

            administrators.Clear();

            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath)) { };
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

                ShowAdminsOnFlowLayoutPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los administradores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return administrators;
        }
    }
}

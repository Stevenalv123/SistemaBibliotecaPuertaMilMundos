using iTextSharp.text.pdf;
using iTextSharp.text;
using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Forms.StudentsForm;

namespace SistemaBiblioteca.Forms
{
    public partial class MainFormStudents : Form
    {
        List<Student> students { get; set; }
        private List<Student> filteredstudents;
        private List<Student> selectedstudents;
        public MainFormStudents()
        {
            InitializeComponent();
            students = new List<Student>();
            filteredstudents = new List<Student>(students);
            selectedstudents = new List<Student>();
        }

        //Abre el formulario para añadir un estudiante
        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudents addStudents = new AddStudents(students, null);
            if (addStudents.ShowDialog() == DialogResult.OK)
            {
                SaveStudents();
                ShowAlert();
                LoadStudents();
            }
        }

        //Guardar estudiantes en archivos
        public void SaveStudents()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaEstudiantes.txt");

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var student in students)
                    {
                        writer.WriteLine($"{student.Carnet},{student.Name},{student.Address},{student.PhoneNumber},{student.Email},{student.Carrer}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cargar la info de archivos y ponerla en el data
        public List<Student> LoadStudents()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaEstudiantes.txt");

            students.Clear();

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
                    MessageBox.Show($"Error al cargar los estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        if (datos.Length == 6)
                        {
                            string carnet = datos[0];
                            string name = datos[1];
                            string address = datos[2];
                            string phoneNumber = datos[3];
                            string email = datos[4];
                            string carrer = datos[5];

                            students.Add(new Student(carnet, name, address, phoneNumber, email, carrer));
                        }
                    }
                }

                UpdateStudentsList(students);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return students;
        }

        //Mostrar alerta de guardado
        private async void ShowAlert()
        {
            AlertForm alert = new AlertForm();
            alert.Show();
            await Task.Delay(3000);
            alert.Close();
        }

        //Cargar la info
        private void MainFormStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        //Imprimir la info de usuarios
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        //Metodo para generar pdf
        public void ExportToPDF()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Guardar Reporte de Estudiantes",
                    FileName = "Estudiantes.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Document pdfDoc = new Document(PageSize.A4, 10, 10, 50, 50);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                    pdfDoc.Open();

                    Paragraph libraryName = new Paragraph("Biblioteca Puerta a Mil Mundos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                    libraryName.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(libraryName);

                    using (MemoryStream logoStream = new MemoryStream())
                    {
                        Properties.Resources.PuertasAMilMundosLogo.Save(logoStream, System.Drawing.Imaging.ImageFormat.Png);  // Utiliza System.Drawing.Image aquí
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoStream.ToArray());  // Usa iTextSharp.text.Image aquí
                        logo.ScaleAbsolute(100f, 80f);
                        logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                        pdfDoc.Add(logo);
                    }

                    Paragraph title = new Paragraph("Lista de Estudiantes", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    pdfDoc.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(6);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 1f, 2f, 2f, 2f, 2f, 2f });

                    string[] headers = { "Carnet", "Nombre", "Dirección", "Teléfono", "Email", "Carrera" };
                    foreach (string header in headers)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                        cell.BackgroundColor = new BaseColor(200, 200, 200);
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    foreach (var student in students)
                    {
                        table.AddCell(student.Carnet);
                        table.AddCell(student.Name);
                        table.AddCell(student.Address);
                        table.AddCell(student.PhoneNumber);
                        table.AddCell(student.Email);
                        table.AddCell(student.Carrer);
                    }

                    pdfDoc.Add(table);

                    pdfDoc.Close();

                    MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar estudiantes
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = TxtSearch.Text.Trim().ToLower();
            filteredstudents = students.Where(a => a.Carnet.ToLower().Contains(search)
                              || a.Name.ToLower().Contains(search)
                              || a.Carrer.ToLower().Contains(search)).ToList();
            UpdateStudentsList(filteredstudents);
        }

        //Actualizar el datagridview
        private void UpdateStudentsList(List<Student> studentsToShow)
        {
            DtvStudents.Rows.Clear();
            foreach (Student student in studentsToShow.OrderBy(a => a.Name))
            {
                DtvStudents.Rows.Add(student.Carnet, student.Name, student.Address, student.PhoneNumber, student.Email, student.Carrer);
            }
        }

        //Eliminar estudiante
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DtvStudents.SelectedRows.Count > 0)
            {
                string carnetToDelete = DtvStudents.SelectedRows[0].Cells[0].Value.ToString();

                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este estudiante?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var studentToRemove = students.FirstOrDefault(s => s.Carnet == carnetToDelete);

                    if (studentToRemove != null)
                    {
                        students.Remove(studentToRemove);
                        MessageBox.Show("Estudiante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SaveStudents();

                        UpdateStudentsList(students);
                    }
                    else
                    {
                        MessageBox.Show("Estudiante no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Obtener indice seleccionado
        private void DtvStudents_SelectionChanged(object sender, EventArgs e)
        {
            BtnDelete.Enabled = DtvStudents.SelectedRows.Count > 0;
            BtnEdit.Enabled = DtvStudents.SelectedRows.Count > 0;
        }

        //Editar estudiante
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DtvStudents.SelectedRows.Count > 0)
            {
                string carnetToEdit = DtvStudents.SelectedRows[0].Cells[0].Value.ToString();

                Student studentToEdit = students.FirstOrDefault(s => s.Carnet == carnetToEdit);

                if (studentToEdit != null)
                {
                    AddStudents addStudents = new AddStudents(students, studentToEdit);

                    if (addStudents.ShowDialog() == DialogResult.OK)
                    {
                        UpdateStudentsList(students);
                        filteredstudents = new List<Student>(students);
                        SaveStudents();
                    }
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Atajos de teclado
        private void MainFormStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                TxtSearch.Focus();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                BtnAddStudent_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                BtnEdit_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                BtnDelete_Click(sender, e);
            }
        }
    }
}

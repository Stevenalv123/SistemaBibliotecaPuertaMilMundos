using SistemaBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms.DevolutionsForms
{
    public partial class DevolutionForm : Form
    {
        public List<Loan> loans;
        public DevolutionForm()
        {
            InitializeComponent();
            loans = new List<Loan>();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            NewPrestamo newPrestamo = new NewPrestamo(loans);
            if (newPrestamo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se hizo el prestamo correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveLoans();
                LoadInfoOnDataGridView(loans);
            }
        }

        private void DevolutionForm_Load(object sender, EventArgs e)
        {
            loans = LoadLoanFile();
            LoadInfoOnDataGridView(loans);
        }

        private void LoadInfoOnDataGridView(List<Loan> loans)
        {
            DtvLoans.Rows.Clear();
            foreach (Loan loan in loans.OrderBy(a => a.Loan_Date))
            {
                DtvLoans.Rows.Add(loan.Loan_Code,loan.Student_name.Name,loan.Books,loan.Loan_Date,loan.Return_Date);
            }
        }

        private void SaveLoans()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaPrestamos.txt");

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var loan in loans)
                    {
                        writer.WriteLine($"{loan.Loan_Code},{loan.Student_name.Name},{loan.Books},{loan.Loan_Date},{loan.Return_Date}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Loan> LoadLoanFile()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaPrestamos.txt");

            if (loans == null)
                loans = new List<Loan>();

            loans.Clear();

            // Crear carpeta y archivo si no existen
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
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return loans;
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

                        if (datos.Length == 5)
                        {
                            string codigo = datos[0];
                            Student studentName = new Student("",datos[1],"","","","");
                            string book = datos[2];

                            if (!DateTime.TryParse(datos[3], out DateTime loanDate))
                            {
                                MessageBox.Show($"Formato de fecha inválido: {datos[3]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                continue;
                            }

                            if (!DateTime.TryParse(datos[4], out DateTime returnLoanDate))
                            {
                                MessageBox.Show($"Formato de fecha inválido: {datos[4]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                continue;
                            }

                            loans.Add(new Loan(studentName, book, loanDate, returnLoanDate));
                        }
                    }
                }

                LoadInfoOnDataGridView(loans);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los registros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return loans;
        }
    }
}

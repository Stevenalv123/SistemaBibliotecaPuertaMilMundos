using SistemaBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms.DevolutionsForms
{
    public partial class NewPrestamo : Form
    {
        public List<Student> students;
        public List<Book> books;
        public List<Book> selectedBooks { get; set; }
        public List<Loan> loans;
        public NewPrestamo(List<Loan> loans)
        {
            InitializeComponent();
            students = new List<Student>();
            books = new List<Book>();
            selectedBooks = new List<Book>();
            this.loans = loans;
        }

        private void TxtStudents_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtStudents.Text))
            {
                LstStudents.Visible = true;
            }
            else
            {
                LstStudents.Visible = false;
                LstStudents.SelectedIndex = -1;
            }

            LstStudents.DataSource = SearchStudents();
            LstStudents.DisplayMember = "Name";
        }

        public static List<Student> LoadStudents()
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string rutaArchivo = Path.Combine(rutaCarpeta, "ListaEstudiantes.txt");

            List<Student> students = new List<Student>();

            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("Usted no tiene registro de estudiantes", "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Student>();
            }

            try
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return students;
        }

        public static List<Book> LoadBooks()
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string rutaArchivo = Path.Combine(rutaCarpeta, "ListaLibros.txt");

            List<Book> books = new List<Book>();

            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("Usted no tiene registro de libros", "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Book>();
            }

            try
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] datos = line.Split(',');

                        if (datos.Length >= 8)
                        {
                            // Crear un nuevo libro a partir de los datos
                            var book = new Book(
                                datos[0], // Title
                                datos[1], // Author
                                new Categorie(datos[2]), // Categorie
                                datos[3], // ISBN
                                new Editorial(datos[3], "", "", ""), // Editorial
                                Convert.ToInt32(datos[5]), // YearPublication
                                Convert.ToInt32(datos[6]), // Stock
                                (State)Enum.Parse(typeof(State), datos[7]), // BookState
                                Convert.ToInt32(datos[8]) // Pages
                            );

                            books.Add(book);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return books;
        }

        private void NewPrestamo_Load(object sender, EventArgs e)
        {
            students = LoadStudents();
            LstStudents.DataSource = students;
            LstStudents.DisplayMember = "Name";
            LstStudents.SelectedIndex = -1;

            books = LoadBooks();
            LstBooks.DataSource = books;
            LstBooks.DisplayMember = "Title";
            LstBooks.SelectedIndex = -1;

            TxtStudents.Text = string.Empty;
            TxtBooks.Text = string.Empty;
            BtnReady.Visible = false;
            LblSelectedBooks.Visible = false;
            AddDates();
        }

        private List<Student> SearchStudents()
        {
            LstStudents.SelectedIndex = -1;
            List<Student> filteredStudents = new List<Student>();
            string search = TxtStudents.Text.Trim().ToLower();
            filteredStudents = students.Where(a => a.Carnet.ToLower().Contains(search)
                              || a.Name.ToLower().Contains(search)).ToList();
            return filteredStudents;
        }

        private void LstStudents_Click(object sender, EventArgs e)
        {
            if (TxtStudents.Text != string.Empty)
            {
                TxtStudents.Text = ((Student)LstStudents.SelectedItem).Name;
                LstStudents.Visible = false;
            }
        }

        private void AddDates()
        {
            DtpLoanDevolution.Value = DtpLoanDate.Value;
            DtpLoanDevolution.Value = DtpLoanDevolution.Value.AddDays(5);
        }

        private void DtpLoanDate_ValueChanged(object sender, EventArgs e)
        {
            AddDates();
        }

        private void BtnLookBooks_Click(object sender, EventArgs e)
        {
            LstBooks.Visible = true;
            BtnReady.Visible = true;
            TxtSearch.Visible = true;
            BtnSearch.Visible = true;
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {
            LstBooks.Visible = false;
            BtnReady.Visible = false;
            LblSelectedBooks.Visible = false;
            TxtSearch.Visible = false;
            BtnSearch.Visible = false;

            TxtBooks.Text = string.Join(", ", selectedBooks.Select(a => a.Title));
        }

        private void LstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBooks.Clear();
            LblSelectedBooks.Visible = true;

            if (LstBooks.SelectedIndices.Count > 0)
            {
                BtnReady.Visible = true;

                foreach (int index in LstBooks.SelectedIndices)
                {
                    var book = (Book)LstBooks.Items[index];
                    selectedBooks.Add(book);
                }

                LblSelectedBooks.Text = $"Autores seleccionados: {selectedBooks.Count}";
            }
            else
            {
                LblSelectedBooks.Text = "Autores seleccionados: 0";
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LstBooks.DataSource = SearchBook();
            LstBooks.DisplayMember = "Title";
        }

        private List<Book> SearchBook()
        {
            LstBooks.SelectedIndex = -1;
            List<Book> filteredBooks = new List<Book>();
            string search = TxtSearch.Text.Trim().ToLower();
            filteredBooks = books.Where(a => a.Title.ToLower().Contains(search)
                              || a.ISBN.ToLower().Contains(search)
                              || a.Author.ToLower().Contains(search)).ToList();
            return filteredBooks;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Student studentname = (Student)LstStudents.SelectedItem;
            string books = TxtBooks.Text;
            DateTime loandate = DtpLoanDate.Value;
            DateTime returndate= DtpLoanDevolution.Value;

            if(studentname != null && !string.IsNullOrEmpty(TxtBooks.Text))
            {
                Loan loan = new Loan(studentname, books, loandate, returndate);
                loans.Add(loan);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Rellene todos los campos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            
        }
    }
}

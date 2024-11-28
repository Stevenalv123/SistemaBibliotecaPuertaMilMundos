using SistemaBiblioteca.Entities;
using System.Data;

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

        //Bucar estudiantes para buscarlos en el listbox
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

        //Cargar los estudiantes en el listbox
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

        //Cargar los libros en el listbox
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
                            var book = new Book(
                                datos[0],
                                datos[1], 
                                new Categorie(datos[2]), 
                                datos[3], 
                                new Editorial(datos[3], "", "", ""), 
                                Convert.ToInt32(datos[5]), 
                                Convert.ToInt32(datos[6]),
                                (State)Enum.Parse(typeof(State), datos[7]),
                                Convert.ToInt32(datos[8])
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

        //Cargar la info en los listboxes
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
            AddDates();
        }

        //Metodo para buscar estudiantes
        private List<Student> SearchStudents()
        {
            LstStudents.SelectedIndex = -1;
            List<Student> filteredStudents = new List<Student>();
            string search = TxtStudents.Text.Trim().ToLower();
            filteredStudents = students.Where(a => a.Carnet.ToLower().Contains(search)
                              || a.Name.ToLower().Contains(search)).ToList();
            return filteredStudents;
        }

        //Obtener el item seleccionado en el listbox
        private void LstStudents_Click(object sender, EventArgs e)
        {
            if (TxtStudents.Text != string.Empty)
            {
                TxtStudents.Text = ((Student)LstStudents.SelectedItem).Name;
                LstStudents.Visible = false;
            }
        }

        //Agregarle 5 dias a la fecha de hoy para la fecha de devolucion
        private void AddDates()
        {
            DtpLoanDevolution.Value = DtpLoanDate.Value;
            DtpLoanDevolution.Value = DtpLoanDevolution.Value.AddDays(5);
        }

        //Obtener algun cambio de fecha
        private void DtpLoanDate_ValueChanged(object sender, EventArgs e)
        {
            AddDates();
        }

        //Buscar libros en el listbox
        private void TxtBook_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBooks.Text))
            {
                LstBooks.Visible = true;
            }
            else
            {
                LstBooks.Visible = false;
                LstBooks.SelectedIndex = -1;
            }

            LstBooks.DataSource = SearchBook();
            LstBooks.DisplayMember = "Title";
        }

        //Metodo para buscar
        private List<Book> SearchBook()
        {
            LstBooks.SelectedIndex = -1;
            List<Book> filteredBooks = new List<Book>();
            string search = TxtBooks.Text.Trim().ToLower();
            filteredBooks = books.Where(a => a.Title.ToLower().Contains(search)
                              || a.ISBN.ToLower().Contains(search)
                              || a.Author.ToLower().Contains(search)).ToList();
            return filteredBooks;
        }

        //Guardar esa info y cerrar el formulario
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Student studentName = (Student)LstStudents.SelectedItem;
            Book book = (Book)LstBooks.SelectedItem;
            DateTime loanDate = DtpLoanDate.Value;
            DateTime returnDate = DtpLoanDevolution.Value;
            string observations = TxtObservations.Text;

            if (studentName == null || book == null || string.IsNullOrEmpty(observations))
            {
                MessageBox.Show("Rellene todos los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoanState state = LoanState.Prestado;

            Loan loan = new Loan(studentName, book, loanDate, returnDate, observations, state, null);

            if (returnDate < DateTime.Now)
            {
                int daysLate = (DateTime.Now - returnDate).Days;
                Fine fine = new FineDaysLate(loan, 0, daysLate);
                loan.Fine = fine;
                loan.State = LoanState.Vencido;
            }

            loans.Add(loan);
            DialogResult = DialogResult.OK;
        }

        //Obtener el item seleccionado en el listbox de libros
        private void LstBooks_Click(object sender, EventArgs e)
        {
            if (TxtBooks.Text != string.Empty)
            {
                TxtBooks.Text = ((Book)LstBooks.SelectedItem).Title;
                LstBooks.Visible = false;
            }
        }
    }
}

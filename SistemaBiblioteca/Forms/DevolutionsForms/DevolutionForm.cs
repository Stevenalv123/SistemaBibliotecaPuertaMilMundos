using iTextSharp.text.pdf;
using iTextSharp.text;
using SistemaBiblioteca.Entities;
using System.Data;
using System.Text;

namespace SistemaBiblioteca.Forms.DevolutionsForms
{
    public partial class DevolutionForm : Form
    {
        public List<Loan> loans;
        public List<Devolution> devolutions;
        public DevolutionForm()
        {
            InitializeComponent();
            loans = new List<Loan>();
            devolutions = new List<Devolution>();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            NewPrestamo newPrestamo = new NewPrestamo(loans);
            if (newPrestamo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se hizo el prestamo correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveLoans();
                LoadInfoOnDataGridView();
            }
        }

        private void DevolutionForm_Load(object sender, EventArgs e)
        {
            loans = LoadLoanFile();
            LoadInfoOnDataGridView();
            devolutions=LoadDevolutionsFromFile();
            LoadDevolutionOnDataGridView(devolutions);
        }

        private void LoadInfoOnDataGridView()
        {
            DtvLoans.Rows.Clear();
            foreach (Loan loan in loans.OrderBy(a => a.Loan_Date))
            {
                string fineAmount = loan.Fine != null ? loan.Fine.TotalFine.ToString() : "No aplica";
                DtvLoans.Rows.Add(loan.Loan_Code, loan.Student_name.Name, loan.Book.Title, loan.Loan_Date, loan.Return_Date, loan.Observations, loan.State, fineAmount);
            }

            if (!(DtvLoans.Columns.Contains("BtnEntregado") && (DtvLoans.Columns.Contains("BtnPrint"))))
            {
                DataGridViewButtonColumn buttonEntregado = new DataGridViewButtonColumn
                {
                    Name = "BtnEntregado",
                    HeaderText = "Marcar como entregado",
                    Text = "Entregar",
                    UseColumnTextForButtonValue = true
                };

                DataGridViewButtonColumn buttonPrint = new DataGridViewButtonColumn
                {
                    Name = "BtnPrint",
                    HeaderText = "Imprimir",
                    Text = "Imprimir",
                    UseColumnTextForButtonValue = true
                };

                DtvLoans.Columns.Add(buttonEntregado);
                DtvLoans.Columns.Add(buttonPrint);
            }
        }

        public void LoadDevolutionOnDataGridView(List<Devolution> devolutions)
        {
            DtvDevoluciones.Rows.Clear();
            foreach (Devolution devolution in devolutions.OrderBy(a => a.DevolutionDate))
            {
                DtvDevoluciones.Rows.Add(devolution.LoanCode, devolution.Student, devolution.Book, devolution.DevolutionDate, devolution.Condition, devolution.Fine);
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
                        writer.WriteLine($"{loan.Loan_Code},{loan.Student_name.Name},{loan.Book.Title},{loan.Loan_Date},{loan.Return_Date},{loan.Observations},{loan.State},{loan.Fine?.TotalFine ?? 0}");
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

                        if (datos.Length == 8)
                        {
                            string codigo = datos[0];
                            Student studentName = new Student("", datos[1], "", "", "", "");
                            Book book = new Book(datos[2], null, null, "", null, 0, 0, 0, 0);

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

                            string observations = datos[5];
                            LoanState state = Enum.Parse<LoanState>(datos[6]);
                            Fine fine = null;

                            if (returnLoanDate < DateTime.Now)
                            {
                                int daysLate = (DateTime.Now - returnLoanDate).Days;
                                fine = new FineDaysLate(null, 0, daysLate);
                                state = LoanState.Vencido;
                            }

                            Loan loan = new Loan(studentName, book, loanDate, returnLoanDate, observations, state, fine);
                            loans.Add(loan);
                        }
                    }
                }

                LoadInfoOnDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los registros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return loans;
        }

        private void DtvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DtvLoans.Columns["BtnEntregado"].Index && e.RowIndex >= 0)
            {
                Loan loan = loans[e.RowIndex];

                if (loan.State == LoanState.Entregado)
                {
                    MessageBox.Show("El libro ya ha sido entregado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var loanCode = DtvLoans.Rows[e.RowIndex].Cells["Cell_Codigo"].Value.ToString();
                var studentName = DtvLoans.Rows[e.RowIndex].Cells["Cell_Student"].Value.ToString();
                var bookTitle = DtvLoans.Rows[e.RowIndex].Cells["Cell_Book"].Value.ToString();

                ConditionsForms conditionsForm = new ConditionsForms(loan,devolutions,DtvDevoluciones);
                if (conditionsForm.ShowDialog() != DialogResult.OK)
                {
                    loan.State = LoanState.Entregado;
                }

                SaveLoans();
                LoadInfoOnDataGridView();
                SaveDevolutionsOnFile();
                LoadDevolutionOnDataGridView(devolutions);
            }

            if(e.ColumnIndex == DtvLoans.Columns["BtnPrint"].Index && e.RowIndex >= 0)
            {
                var loanCode = DtvLoans.Rows[e.RowIndex].Cells["Cell_Codigo"].Value.ToString();
                var studentName = DtvLoans.Rows[e.RowIndex].Cells["Cell_Student"].Value.ToString();
                var bookTitle = DtvLoans.Rows[e.RowIndex].Cells["Cell_Book"].Value.ToString();
                var devolutionDate = DateTime.Parse(DtvLoans.Rows[e.RowIndex].Cells["Cell_LoanDevolutiondate"].Value.ToString());
                ExportToPDF(studentName,bookTitle,devolutionDate);
            }
        }

        public void EliminarDevolucion(string loanCode)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaDevoluciones.txt");
            try
            {
                var lines = File.ReadAllLines(filePath).ToList();

                var lineToRemove = lines.FirstOrDefault(line => line.StartsWith(loanCode));

                if (lineToRemove != null)
                {
                    lines.Remove(lineToRemove);

                    File.WriteAllLines(filePath, lines, Encoding.UTF8);
                    MessageBox.Show("Devolución eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la devolución con ese código.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la devolución: " + ex.Message);
            }
        }


        private void SaveDevolutionsOnFile()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaDevoluciones.txt");

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var devolution in devolutions)
                    {
                        writer.WriteLine($"{devolution.LoanCode},{devolution.Student},{devolution.Book},{devolution.DevolutionDate},{devolution.Condition},{devolution.Fine}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las devoluciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Devolution> LoadDevolutionsFromFile()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaDevoluciones.txt");

            devolutions.Clear();

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
                    MessageBox.Show($"Error al cargar los registros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 6)
                        {
                            string loanCode = parts[0];
                            string student = parts[1];
                            string book = parts[2];
                            DateTime devolutionDate = DateTime.Parse(parts[3]);
                            ReturnCondition condition = (ReturnCondition)Enum.Parse(typeof(ReturnCondition), parts[4]);
                            decimal fine = decimal.Parse(parts[5]);

                            devolutions.Add(new Devolution(loanCode, book, student, devolutionDate, condition, fine));
                        }
                    }
                }
                LoadDevolutionOnDataGridView(devolutions);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las devoluciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return devolutions;
        }

        public void ExportToPDF(string name, string book, DateTime devolutiondate)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Guardar Recibo",
                    FileName = "Recibo.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Document pdfDoc = new Document(PageSize.A7, 50, 50, 50, 50);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                    pdfDoc.Open();

                    Paragraph header = new Paragraph("Biblioteca Puerta a Mil Mundos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9));
                    header.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(header);

                    Paragraph receiptTitle = new Paragraph("RECIBO DE TRANSACCIÓN", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8));
                    receiptTitle.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(receiptTitle);

                    pdfDoc.Add(new Paragraph("\n"));

                    PdfPTable infoTable = new PdfPTable(2);
                    infoTable.WidthPercentage = 80;
                    infoTable.HorizontalAlignment = Element.ALIGN_CENTER;
                    infoTable.SpacingAfter = 20;

                    string[,] receiptData = new string[,]
                    {
                        { "Fecha:", DateTime.Now.ToString("dd/MM/yyyy") },
                        { "Estudiante:", name},
                        { "Libro Prestado:", book },
                        { "Fecha de Devolución:",devolutiondate.ToString("dd/MM/yyyy") }
                    };

                    for (int i = 0; i < receiptData.GetLength(0); i++)
                    {
                        PdfPCell labelCell = new PdfPCell(new Phrase(receiptData[i, 0], FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 5)));
                        labelCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        labelCell.HorizontalAlignment = Element.ALIGN_LEFT;
                        infoTable.AddCell(labelCell);

                        PdfPCell valueCell = new PdfPCell(new Phrase(receiptData[i, 1], FontFactory.GetFont(FontFactory.HELVETICA, 5)));
                        valueCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        valueCell.HorizontalAlignment = Element.ALIGN_LEFT;
                        infoTable.AddCell(valueCell);
                    }

                    pdfDoc.Add(infoTable);

                    Paragraph footer = new Paragraph("Firma del Encargado\n\n_________________________", FontFactory.GetFont(FontFactory.HELVETICA, 10));
                    footer.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(footer);

                    pdfDoc.Close();

                    MessageBox.Show("Recibo generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el recibo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

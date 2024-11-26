using FontAwesome.Sharp;
using SistemaBiblioteca.Forms.Books;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SistemaBiblioteca.Forms
{
    public partial class MainFormBooks : Form
    {
        List<Book> books;
        public MainFormBooks()
        {
            InitializeComponent();
            books = new List<Book>();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialogBooks.ShowDialog();
        }

        private void AddNewBook(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks(books);
            addBooks.ShowDialog();
            if (addBooks.DialogResult == DialogResult.OK)
            {
                ShowAlert();
                ShowBooksOnFlowLayoutPanel();
            }
        }

        private async void ShowAlert()
        {
            AlertForm alert = new AlertForm();
            alert.Show();
            await Task.Delay(3000);
            alert.Close();
        }

        private void ShowBooksOnFlowLayoutPanel()
        {
            Color redColor = Color.FromArgb(185, 27, 33);
            Color blueColor=Color.FromArgb(40, 68, 131);
            FlpBooks.Controls.Clear(); // Limpia el FlowLayoutPanel antes de agregar nuevas tarjetas.

            foreach (var book in books)
            {
                // Crear un Panel que actuará como la "tarjeta"
                var cardPanel = new Panel
                {
                    Width = 250,
                    Height = 400,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                // PictureBox para la portada del libro
                var coverPictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    Image = book.Cover,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.None
                };

                // Label para el título
                var titleLabel = new Label
                {
                    Text = book.Title,
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30
                };

                // Label para mostrar la categoría
                var categoryLabel = new Label
                {
                    Text = $"Categoría: {book.Categorie.Name}",
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 25
                };

                // Label para el estado del libro
                var stateLabel = new Label
                {
                    Text = $"Estado: {book.BookState}",
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    ForeColor = Color.DarkBlue,
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
                    Text="",
                    Size = new Size(80, 60),
                    Dock = DockStyle.Right,
                    BackColor = blueColor,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Cursor = Cursors.Hand
                };

                var deleteButton=new IconButton
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

                // Botón para ver detalles
                var viewButton = new Button
                {
                    Text = "Ver detalles",
                    Font = new Font("Cambria", 15, FontStyle.Regular),
                    Dock = DockStyle.Bottom,
                    Height = 50,
                    BackColor = blueColor,
                    Tag = book,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Cursor = Cursors.Hand
                };

                // Evento click para el botón
                viewButton.Click += (s, e) =>
                {
                    var clickedBook = (Book)((Button)s).Tag;
                    MessageBox.Show($"Título: {clickedBook.Title}\nAutor(es): {string.Join(", ", clickedBook.Author.Select(a => a.Name))}\nCategoría: {clickedBook.Categorie.Name}\nEstado: {clickedBook.BookState}\nPáginas: {clickedBook.Pages}\nISBN: {clickedBook.ISBN}", "Detalles del Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                // Agregar controles al Panel de la tarjeta
                cardPanel.Controls.Add(viewButton);
                cardPanel.Controls.Add(buttonPanel);
                cardPanel.Controls.Add(stateLabel);
                cardPanel.Controls.Add(categoryLabel);
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(coverPictureBox);

                // Agregar la tarjeta al FlowLayoutPanel
                FlpBooks.Controls.Add(cardPanel);
            }
        }

        private void MainFormBooks_Load(object sender, EventArgs e)
        {
            ShowBooksOnFlowLayoutPanel();
        }
    }
}
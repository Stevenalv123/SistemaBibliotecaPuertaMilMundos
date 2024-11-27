using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Forms;

namespace SistemaBiblioteca.Forms
{
    public partial class MainFormBooks:Form
    {
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
            Color blueColor = Color.FromArgb(40, 68, 131);
            FlpBooks.Controls.Clear();

            foreach (var book in books)
            {
                var cardPanel = new Panel
                {
                    Width = 250,
                    Height = 400,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                var coverPictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    Image = Properties.Resources.book,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.None
                };

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

                viewButton.Click += (s, e) =>
                {
                    var clickedBook = (Book)((Button)s).Tag;
                    MessageBox.Show(clickedBook.ToString());
                };

                cardPanel.Controls.Add(viewButton);
                cardPanel.Controls.Add(buttonPanel);
                cardPanel.Controls.Add(stateLabel);
                cardPanel.Controls.Add(categoryLabel);
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(coverPictureBox);

                FlpBooks.Controls.Add(cardPanel);
            }
        }

        public void SaveBooksToFile()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaLibros.txt");

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var book in books)
                    {
                        writer.WriteLine($"{book.Title},{book.Author}, {book.Categorie.Name}, {book.ISBN},{book.Editorial.Name},{book.YearPublication}, {book.Stock},{book.BookState},{book.Pages}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadBooksFromFile()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaLibros.txt");
            if (File.Exists(filePath))
            {
                books.Clear();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var bookData = line.Split(',');

                        // Verificar que la línea contenga suficientes datos
                        if (bookData.Length >= 8)
                        {
                            // Crear un nuevo libro a partir de los datos
                            var book = new Book(
                                bookData[0], // Title
                                bookData[1], // Author
                                new Categorie(bookData[2]), // Categorie
                                bookData[3], // ISBN
                                new Editorial(bookData[4],"","",""), // Editorial
                                Convert.ToInt32(bookData[5]), // YearPublication
                                Convert.ToInt32(bookData[6]), // Stock
                                (State)Enum.Parse(typeof(State), bookData[7]), // BookState
                                Convert.ToInt32(bookData[8]) // Pages
                            );

                            books.Add(book);
                        }
                    }
                }
                ShowBooksOnFlowLayoutPanel();  // Actualizar el FlowLayoutPanel con los libros cargados
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath)) { }
            }
        }
    }
}

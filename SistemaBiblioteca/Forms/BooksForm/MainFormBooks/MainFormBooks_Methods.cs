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

        private void ShowBooksOnDataGridView()
        {
            DtvStudents.Rows.Clear();
            foreach (Book book in books.OrderBy(a => a.Title))
            {
                DtvStudents.Rows.Add(book.Title,book.Author,book.Categorie.Name,book.ISBN, book.Editorial.Name, book.YearPublication, book.Stock, book.BookState, book.Pages);
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
                ShowBooksOnDataGridView();  // Actualizar el FlowLayoutPanel con los libros cargados
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath)) { }
            }
        }
    }
}

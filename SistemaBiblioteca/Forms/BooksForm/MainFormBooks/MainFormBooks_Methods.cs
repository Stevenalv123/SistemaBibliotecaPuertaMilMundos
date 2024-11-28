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
        //Muestra un form personalizado para indicar que se guardo correctamente
        private async void ShowAlert()
        {
            AlertForm alert = new AlertForm();
            alert.Show();
            await Task.Delay(3000);
            alert.Close();
        }

        //Muestra los libros en el data
        private void ShowBooksOnDataGridView()
        {
            DtvBooks.Rows.Clear();
            foreach (Book book in books.OrderBy(a => a.Title))
            {
                DtvBooks.Rows.Add(book.Title,book.Author,book.Categorie.Name,book.ISBN, book.Editorial.Name, book.YearPublication, book.Stock, book.BookState, book.Pages);
            }
        }

        //Guardar en archivos
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

        //Cargar en archivos
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

                        if (bookData.Length >= 8)
                        {
                            var book = new Book(
                                bookData[0],
                                bookData[1], 
                                new Categorie(bookData[2]),
                                bookData[3], 
                                new Editorial(bookData[4],"","",""),
                                Convert.ToInt32(bookData[5]), 
                                Convert.ToInt32(bookData[6]),
                                (State)Enum.Parse(typeof(State), bookData[7]), 
                                Convert.ToInt32(bookData[8]) 
                            );

                            books.Add(book);
                        }
                    }
                }
                ShowBooksOnDataGridView(); 
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath)) { }
            }
        }
    }
}

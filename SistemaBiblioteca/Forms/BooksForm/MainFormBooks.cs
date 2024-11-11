using SistemaBiblioteca.Forms.Books;
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
                ReloadDataGridView();
            }
        }

        private async void ShowAlert()
        {
            AlertForm alert = new AlertForm();
            alert.Show();
            await Task.Delay(3000);
            alert.Close();
        }

        private void ReloadDataGridView()
        {
            dtgBooks.Rows.Clear();

            foreach (var book in books)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgBooks);

                row.Cells[0].Value = book.Id_Book;
                row.Cells[1].Value = book.Title;
                row.Cells[2].Value = book.Author != null ? string.Join(", ", book.Author.Select(a => a.Name)) : "S/A";
                row.Cells[3].Value = book.ISBN;
                row.Cells[4].Value = book.Categorie.Name;
                row.Cells[5].Value = book.Editorial != null ? book.Editorial.Name : "N/A";
                row.Cells[6].Value = book.YearPublication;
                row.Cells[7].Value = book.Stock;
                row.Cells[8].Value = book.BookState;

                dtgBooks.Rows.Add(row);
            }
        }

    }
}

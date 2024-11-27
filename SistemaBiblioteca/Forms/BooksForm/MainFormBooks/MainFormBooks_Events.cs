using SistemaBiblioteca.Forms.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBiblioteca.Forms;

namespace SistemaBiblioteca.Forms
{
    public partial class MainFormBooks : Form
    {
        private void MainFormBooks_Load(object sender, EventArgs e)
        {
            LoadBooksFromFile();
            ShowBooksOnFlowLayoutPanel();
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
                SaveBooksToFile();
                ShowAlert();
                LoadBooksFromFile();
                ShowBooksOnFlowLayoutPanel();
            }
        }
    }
}

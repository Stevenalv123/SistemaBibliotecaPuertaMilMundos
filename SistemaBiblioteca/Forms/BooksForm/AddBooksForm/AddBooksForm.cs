using Microsoft.Win32;
using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Forms.BooksForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms.Books
{
    public partial class AddBooks : Form
    {
        bool correctISBN;
        public List<Author> selectedAuthors { get; set; }
        public List<Editorial> editorials { get; set; }
        public List<Categorie> categories { get; set; }
        public List<Book> books { get; set; }
        public AddBooks(List<Book> existingBooks)
        {
            InitializeComponent();
            selectedAuthors = new List<Author>();
            editorials = new List<Editorial>();
            categories = new List<Categorie>();
            books = existingBooks;
        }
    }
}

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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string title = TxtTitle.Text;
                string isbn = MtbISBN.Text;
                Editorial editorial = editorials != null ? editorials.Find(e => e.Name == CmbEditorial.Text) : null;
                int yearPublication = Convert.ToInt32(MtbPublicationYear.Text);
                int stock = (int)NudStock.Value;
                int pages = (int)NudPages.Value;
                State state = State.Disponible;
                Categorie categorie = (Categorie)CmbCategories.SelectedItem;
                List<Author> authors = selectedAuthors;
                string coverPath = PcbCover.ImageLocation; // Obtiene la ubicación del archivo seleccionado
                Image coverImage = null;

                if (!string.IsNullOrEmpty(coverPath))
                {
                    coverImage = new Bitmap(coverPath); // Carga la imagen en la propiedad
                }
                else
                {
                    coverImage = Properties.Resources.book;
                }

                Book book = new Book(title, authors, categorie, isbn, editorial, yearPublication, stock, state, coverImage, pages);
                book.AddBook(books);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al agregar el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateForm()
        {
            bool isTitleValid = !string.IsNullOrEmpty(TxtTitle.Text);
            bool isISBNValid = correctISBN;
            bool isCategorieValid = CmbCategories.SelectedItem != null;

            BtnSave.Enabled = isTitleValid && isISBNValid && isCategorieValid;
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorsForms autorForm = new AuthorsForms(selectedAuthors);
            if (autorForm.ShowDialog() == DialogResult.OK)
            {
                TxtAuthors.Text = string.Join(", ", selectedAuthors.Select(a => a.Name));
            }
        }

        private void BtnAddEditorial_Click(object sender, EventArgs e)
        {
            AddEditorialForm addEditorialForm = new AddEditorialForm(editorials);
            if (addEditorialForm.ShowDialog() == DialogResult.OK)
            {
                // Actualizar el ComboBox con la lista de editoriales actualizada
                CmbEditorial.DataSource = null;
                CmbEditorial.DataSource = editorials;
                CmbEditorial.DisplayMember = "Name";
            }
        }

        private void MtbISBN_TextChanged(object sender, EventArgs e)
        {
            LblIconFormat.Text = "✘";
            LblIconFormat.ForeColor = Color.Red;
            LblFormatStatus.Text = "El ISBN debe tener 13 dígitos";
            correctISBN = false;
            ValidateForm();

            if (MtbISBN.MaskFull)
            {
                LblIconFormat.Text = "✔";
                LblIconFormat.ForeColor = Color.LightGreen;
                LblFormatStatus.Text = "Formato válido";
                correctISBN = true;
                ValidateForm();
            }
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            AddCategorieForm addCategorieForm = new AddCategorieForm(categories);
            if (addCategorieForm.ShowDialog() == DialogResult.OK)
            {
                // Actualizar el ComboBox con la lista de categorias actualizada
                CmbCategories.DataSource = null;
                CmbCategories.DataSource = categories.ToList();
                CmbCategories.DisplayMember = "Name";
            }
        }

        private void PcbCover_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PcbCover.Image = new Bitmap(openFileDialog.FileName);
                PcbCover.ImageLocation = openFileDialog.FileName; 
            }
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}

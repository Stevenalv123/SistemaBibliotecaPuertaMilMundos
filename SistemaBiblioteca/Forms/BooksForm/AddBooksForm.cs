﻿using SistemaBiblioteca.Entities;
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
            string title = TxtTitle.Text;

            

            Categorie categorie = CmbCategories.SelectedItem as Categorie;
            string isbn = MtbISBN.Text;
            Editorial editorial = CmbEditorial.SelectedItem as Editorial;
            int yearPublication = int.Parse(MtbPublicationYear.Text);
            int stock = int.Parse(MtbStock.Text);
            State bookState = State.Disponible;

            
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
    }
}

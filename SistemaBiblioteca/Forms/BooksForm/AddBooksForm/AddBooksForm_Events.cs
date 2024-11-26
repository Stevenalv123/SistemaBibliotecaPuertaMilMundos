﻿using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Forms.BooksForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Forms.Books
{
    public partial class AddBooks:Form
    {
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
                string coverPath = PcbCover.ImageLocation;
                Image coverImage = null;

                if (!string.IsNullOrEmpty(coverPath))
                {
                    coverImage = new Bitmap(coverPath);
                }
                else
                {
                    coverImage = Properties.Resources.book;
                }

                Book book = new Book(title, authors, categorie, isbn, editorial, yearPublication, stock, coverImage, pages);
                books.Add(book);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al agregar el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                SaveEditorials(editorials);

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
                SaveCategories(categories);

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
            categories = LoadCategories();
            CmbCategories.DataSource = categories;
            CmbCategories.DisplayMember = "Name";
            CmbCategories.ValueMember = "Id_Categorie";

            editorials = LoadEditorials();
            CmbEditorial.DataSource = editorials;
            CmbEditorial.DisplayMember = "Name";
            CmbEditorial.ValueMember = "Id_Editorial";
        }
    }
}

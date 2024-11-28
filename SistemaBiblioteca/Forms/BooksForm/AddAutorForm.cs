using SistemaBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms.BooksForm
{
    public partial class AddAutorForm : Form
    {
        private List<Author> authors;
        private Author authorToEdit;
        public AddAutorForm(List<Author> existingAuthors, Author authorsToEdit)
        {
            InitializeComponent();
            authors = existingAuthors;
            authorToEdit = authorsToEdit;
        }

        //Guarda la info en una lista y cierra el form
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (authorToEdit != null)
            {
                authorToEdit.Name = txtName.Text;
                authorToEdit.Nacionality = txtNacionality.Text;
                authorToEdit.Year_birth = Convert.ToInt32(MtbBirthyear.Text);
                MessageBox.Show("Autor actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult =DialogResult.OK;
            }
            else
            {
                string name = txtName.Text;
                string nationality = txtNacionality.Text;
                int birthYear = Convert.ToInt32(MtbBirthyear.Text);

                authors.Add(new Author(name, nationality, birthYear));
                MessageBox.Show("Autor agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        //Carga la info recibida en los textboxs
        private void AddAutorForm_Load(object sender, EventArgs e)
        {
            if (authorToEdit != null)
            {
                txtName.Text = authorToEdit.Name;
                txtNacionality.Text = authorToEdit.Nacionality;
                MtbBirthyear.Text = authorToEdit.Year_birth.ToString();
            }
            else
            {
                txtName.Text = "";
                txtNacionality.Text = "";
                MtbBirthyear.Text = "";
            }
        }
    }
}

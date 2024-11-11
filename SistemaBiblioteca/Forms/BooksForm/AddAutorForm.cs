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
        public AddAutorForm(List<Author> existingAuthors)
        {
            InitializeComponent();
            authors = existingAuthors;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string nationality = txtNacionality.Text;
            string birthYear = MtbBirthyear.Text;

            authors.Add(new Author(name, nationality, birthYear));
            MessageBox.Show("Autor agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

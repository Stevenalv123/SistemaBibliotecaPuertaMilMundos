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
    public partial class AddCategorieForm : Form
    {
        private List<Categorie> categories;
        public AddCategorieForm(List<Categorie> existingCategories)
        {
            InitializeComponent();
            categories = existingCategories;
        }

        //Guardar las categorias
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("El campo nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                categories.Add(new Categorie(name));
                MessageBox.Show("Categoria agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}

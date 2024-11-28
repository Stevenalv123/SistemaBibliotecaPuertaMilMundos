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
    public partial class AddEditorialForm : Form
    {
        private List<Editorial> editorials;
        public AddEditorialForm(List<Editorial> existingEditorials)
        {
            InitializeComponent();
            editorials = existingEditorials;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Guarda la nueva editorial
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string address = TxtAdress.Text;
            string phoneNumber = MtbPhoneNumber.Text;
            string email = TxtEmail.Text;

            editorials.Add(new Editorial(name, address, phoneNumber, email));
            MessageBox.Show("Editorial agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

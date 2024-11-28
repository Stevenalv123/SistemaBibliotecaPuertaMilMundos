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

namespace SistemaBiblioteca.Forms.AdminsForms
{
    public partial class Register : Form
    {
        List<Administrator> administrators;
        Administrator admin;
        public Register(List<Administrator> administrators, Administrator adminToEdit)
        {
            InitializeComponent();
            this.administrators = administrators;
            admin = adminToEdit;
        }

        //Evento que toma los datos de los textboxs y mandarlos al formulario
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                if(string.IsNullOrWhiteSpace(TxtPassword.Text) || string.IsNullOrWhiteSpace(TxtConfirmPassword.Text))
                {
                    LblErrorPassword.Text = "Porfavor, rellene este campo.";
                    LblErrorPassword.Visible = true;
                    return;
                }
                else if (TxtPassword.Text != TxtConfirmPassword.Text)
                {
                    LblErrorPassword.Text = "Las contraseñas no coinciden.";
                    LblErrorPassword.Visible = true;
                    return;
                }
                else
                {
                    admin.Username = TxtUserName.Text;
                    admin.Password = TxtPassword.Text;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                string username = TxtUserName.Text;
                string password = TxtPassword.Text;
                string confirmPassword = TxtConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(username))
                {
                    LblErrorUserName.Text = "Porfavor, rellene este campo.";
                    LblErrorUserName.Visible = true;
                    return;
                }
                else if (administrators.Exists(admin => admin.Username == username))
                {
                    LblErrorUserName.Text = "El nombre de usuario ya existe.";
                    LblErrorUserName.Visible = true;
                    return;
                }
                else
                {
                    LblErrorUserName.Visible = false;
                    if (password != confirmPassword)
                    {
                        LblErrorPassword.Text = "Las contraseñas no coinciden.";
                        LblErrorPassword.Visible = true;
                        return;
                    }
                    else
                    {
                        Administrator administrator = new Administrator(username, password);
                        administrators.Add(administrator);
                        DialogResult = DialogResult.OK;
                    }

                }
            }
        }

        //Metodo que carga la informacion recibida del formulario anterior
        private void Register_Load(object sender, EventArgs e)
        {
            if (admin != null)
            {
                TxtUserName.Text = admin.Username;
                TxtPassword.Text = admin.Password;
                TxtConfirmPassword.Text = admin.Password;
            }
            else
            {
                TxtUserName.Text = "";
                TxtPassword.Text = "";
                TxtConfirmPassword.Text = "";
            }
            
        }
    }
}

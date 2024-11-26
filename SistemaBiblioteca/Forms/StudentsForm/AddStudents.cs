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
using System.Xml.Linq;

namespace SistemaBiblioteca.Forms.StudentsForm
{
    public partial class AddStudents : Form
    {
        private List<Student> students;
        private Student studentToDelete;

        public AddStudents(List<Student> students, Student studentToDelete)
        {
            InitializeComponent();
            this.students = students;
            this.studentToDelete = studentToDelete;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (studentToDelete == null)
            {
                string email = "";
                string carnet = MtbCarnet.Text;
                string name = TxtName.Text;
                string address = TxtAdress.Text;
                string phoneNumber = MtbTelephone.Text;
                if (ValidarEmail())
                {
                    email = TxtEmail.Text;
                }
                string carrer = TxtCarrer.Text;

                Student student = new Student(carnet, name, address, phoneNumber, email, carrer);
                students.Add(student);

                DialogResult = DialogResult.OK;
            }
            else
            {
                studentToDelete.Carnet = MtbCarnet.Text;
                studentToDelete.Name = TxtName.Text;
                studentToDelete.Address = TxtAdress.Text;
                studentToDelete.PhoneNumber = MtbTelephone.Text;
                studentToDelete.Email = TxtEmail.Text;
                studentToDelete.Carrer = TxtCarrer.Text;

                if (ValidarEmail())
                    MessageBox.Show("Estudiante actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }


        }

        public bool ValidarEmail()
        {
            if (TxtEmail.Text.Contains("@") && TxtEmail.Text.Contains("."))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Email incorrecto");
            }

            return false;
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            if(studentToDelete != null)
            {
                MtbCarnet.Text = studentToDelete.Carnet;
                TxtName.Text = studentToDelete.Name;
                TxtAdress.Text = studentToDelete.Address;
                MtbTelephone.Text = studentToDelete.PhoneNumber;
                TxtEmail.Text = studentToDelete.Email;
                TxtCarrer.Text = studentToDelete.Carrer;
            }
        }
    }
}

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
        private Student studentToUpdate;

        public AddStudents(List<Student> students, Student studentToUpdate)
        {
            InitializeComponent();
            this.students = students;
            this.studentToUpdate = studentToUpdate;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (ValidarEmail() != false &&  ValidarTextboxs()!=false)
            {
                if (studentToUpdate == null)
                {
                    string email = "";
                    string carnet = MtbCarnet.Text;
                    string name = TxtName.Text;
                    string address = TxtAdress.Text;
                    string phoneNumber = MtbTelephone.Text;
                    email = TxtEmail.Text;
                    string carrer = TxtCarrer.Text;

                    Student student = new Student(carnet, name, address, phoneNumber, email, carrer);
                    students.Add(student);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    studentToUpdate.Carnet = MtbCarnet.Text;
                    studentToUpdate.Name = TxtName.Text;
                    studentToUpdate.Address = TxtAdress.Text;
                    studentToUpdate.PhoneNumber = MtbTelephone.Text;
                    studentToUpdate.Email = TxtEmail.Text;
                    studentToUpdate.Carrer = TxtCarrer.Text;
                    
                    MessageBox.Show("Estudiante actualizado correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);  
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        public bool ValidarTextboxs()
        {
            if (MtbCarnet.Text == "" || TxtName.Text == "" || TxtAdress.Text == "" || MtbTelephone.Text == "" || TxtEmail.Text == "" || TxtCarrer.Text == "")
            {
                MessageBox.Show("Llene todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
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
            MtbCarnet.Focus();
            if(studentToUpdate != null)
            {
                MtbCarnet.Text = studentToUpdate.Carnet;
                TxtName.Text = studentToUpdate.Name;
                TxtAdress.Text = studentToUpdate.Address;
                MtbTelephone.Text = studentToUpdate.PhoneNumber;
                TxtEmail.Text = studentToUpdate.Email;
                TxtCarrer.Text = studentToUpdate.Carrer;
            }
        }
    }
}

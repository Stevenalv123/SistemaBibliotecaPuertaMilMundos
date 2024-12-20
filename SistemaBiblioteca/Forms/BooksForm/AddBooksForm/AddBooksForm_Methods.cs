﻿using SistemaBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Forms.Books
{
    public partial class AddBooks: Form
    {
        //Valida la informacion en los textboxs
        private void ValidateForm()
        {
            bool isTitleValid = !string.IsNullOrEmpty(TxtTitle.Text);
            bool isISBNValid = correctISBN;
            bool isCategorieValid = CmbCategories.SelectedItem != null;

            BtnSave.Enabled = isTitleValid && isISBNValid && isCategorieValid;
        }

        //Carga la informacion de los archivos de categorias
        public static List<Categorie> LoadCategories()
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string rutaArchivo = Path.Combine(rutaCarpeta, "ListaCategorias.txt");

            List<Categorie> categories = new List<Categorie>();

            if (!File.Exists(rutaArchivo))
            {
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo)){ }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo de categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] datos = line.Split(',');

                        if (datos.Length == 1)
                        {
                            string name = datos[0].Trim();

                            categories.Add(new Categorie(name));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return categories;
        }

        //Guarda la info en archivos
        private void SaveCategories(List<Categorie> categories)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaCategorias.txt");

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var category in categories)
                    {
                        writer.WriteLine($"{category.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Carga la info de los archivos de editoriales
        public static List<Editorial> LoadEditorials()
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string rutaArchivo = Path.Combine(rutaCarpeta, "ListaEditoriales.txt");

            List<Editorial> editorials = new List<Editorial>();

            if (!File.Exists(rutaArchivo))
            {
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo)) { };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo de editoriales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            int maxId = 0;

            try
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] datos = line.Split(',');

                        if (datos.Length == 4)
                        {
                            string name = datos[0].Trim();
                            string adress = datos[1].Trim();
                            string phone = datos[2].Trim();
                            string email = datos[3].Trim();

                            editorials.Add(new Editorial(name, adress, phone, email){});

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las editoriales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return editorials;
        }

        //Guarda la informacion en los archivos para editoriales
        private void SaveEditorials(List<Editorial> editorials)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string filePath = Path.Combine(folderPath, "ListaEditoriales.txt");

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var editorial in editorials)
                    {
                        writer.WriteLine($"{editorial.Name}, {editorial.Adress}, {editorial.Phone_Number},{editorial.Email}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las editoriales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

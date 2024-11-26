using SistemaBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBiblioteca.Forms.BooksForm
{
    public partial class AuthorsForms : Form
    {
        public List<Author> authors { get; set; }
        public List<Author> selectedAuthors { get; set; }
        private List<Author> filteredAuthors;

        public AuthorsForms(List<Author> selectedAuthors)
        {
            InitializeComponent();
            authors = LoadAuthors();
            filteredAuthors = new List<Author>(authors);
            this.selectedAuthors = selectedAuthors;
        }

        private void AuthorsForms_Load(object sender, EventArgs e)
        {
            UpdateAuthorList(filteredAuthors);
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAutorForm addAutorForm = new AddAutorForm(authors, null);
            if (addAutorForm.ShowDialog() == DialogResult.OK)
            {
                UpdateAuthorList(authors);
                filteredAuthors = new List<Author>(authors);
                SaveAuthorsToFile();
            }
        }

        private void SelectedAuthor(object sender, EventArgs e)
        {
            selectedAuthors.Clear();

            if (lstAuthors.SelectedIndices.Count > 0)
            {
                BtnDeleteAuthor.Enabled = true;
                BtnReady.Visible = true;
                BtnUpdateAuthor.Enabled = lstAuthors.SelectedIndices.Count == 1;

                foreach (int index in lstAuthors.SelectedIndices)
                {
                    var author = (Author)lstAuthors.Items[index];
                    selectedAuthors.Add(author);
                }

                LblSelectedAuthors.Text = $"Autores seleccionados: {selectedAuthors.Count}";
            }
            else
            {
                BtnDeleteAuthor.Enabled = false;
                BtnUpdateAuthor.Enabled = false;
                LblSelectedAuthors.Text = "Autores seleccionados: 0";
            }
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public static List<Author> LoadAuthors()
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string rutaArchivo = Path.Combine(rutaCarpeta, "ListaAutores.txt");

            List<Author> authors = new List<Author>();

            if (File.Exists(rutaArchivo))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(rutaArchivo))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] datos = line.Split(',');

                            if (datos.Length == 3)
                            {
                                string name = datos[0].Trim();
                                string nationality = datos[1].Trim();
                                int birthYear = Convert.ToInt32(datos[2].Trim());

                                authors.Add(new Author(name, nationality, birthYear));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los autores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
            }

            return authors;
        }

        private void UpdateAuthorList(List<Author> authorsToShow)
        {
            lstAuthors.Items.Clear();
            lstAuthors.DisplayMember = "Name";
            foreach (Author author in authorsToShow.OrderBy(a => a.Name))
            {
                lstAuthors.Items.Add(author);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAuthor();
        }

        private void SearchAuthor()
        {
            string search = TxtSearch.Text.Trim().ToLower();
            filteredAuthors = authors.Where(a => a.Name.ToLower().Contains(search)
                              || a.Nacionality.ToLower().Contains(search)
                              || a.Year_birth.ToString().Contains(search)).ToList();
            selectedAuthors.Clear();
            UpdateAuthorList(filteredAuthors);
        }

        private void BtnDeleteAuthor_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar el autor seleccionado?", "Eliminar autor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                foreach (int index in lstAuthors.SelectedIndices.Cast<int>().ToList())
                {
                    authors.Remove(filteredAuthors[index]);
                }
                lstAuthors.SelectedIndex = -1;
                BtnReady.Visible = false;
                LblSelectedAuthors.Visible = false;
                filteredAuthors = new List<Author>(authors);

                SaveAuthorsToFile();

                UpdateAuthorList(filteredAuthors);
            }
        }

        private void SaveAuthorsToFile()
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string rutaArchivo = Path.Combine(rutaCarpeta, "ListaAutores.txt");

            try
            {
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    foreach (Author author in authors)
                    {
                        writer.WriteLine($"{author.Name},{author.Nacionality},{author.Year_birth}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los autores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateAuthor_Click(object sender, EventArgs e)
        {
            if(selectedAuthors.Count > 0)
            {
                AddAutorForm addAutorForm = new AddAutorForm(authors, selectedAuthors[0]);
                if (addAutorForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateAuthorList(selectedAuthors);
                    filteredAuthors = new List<Author>(authors);
                    SaveAuthorsToFile();
                }
            }
        }
    }
}

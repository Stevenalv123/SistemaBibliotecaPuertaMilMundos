using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using SistemaBiblioteca.Entities;
using SistemaBiblioteca.Forms;

namespace SistemaBiblioteca.Forms
{
    public partial class MainFormBooks:Form
    {
        private async void ShowAlert()
        {
            AlertForm alert = new AlertForm();
            alert.Show();
            await Task.Delay(3000);
            alert.Close();
        }

        private void ShowBooksOnFlowLayoutPanel()
        {
            Color redColor = Color.FromArgb(185, 27, 33);
            Color blueColor = Color.FromArgb(40, 68, 131);
            FlpBooks.Controls.Clear();

            foreach (var book in books)
            {
                var cardPanel = new Panel
                {
                    Width = 250,
                    Height = 400,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                var coverPictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    Image = book.Cover,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.None
                };

                var titleLabel = new Label
                {
                    Text = book.Title,
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30
                };

                var categoryLabel = new Label
                {
                    Text = $"Categoría: {book.Categorie.Name}",
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 25
                };

                var stateLabel = new Label
                {
                    Text = $"Estado: {book.BookState}",
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    ForeColor = Color.DarkBlue,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 25
                };

                var editButton = new IconButton
                {
                    IconChar = IconChar.Pencil,
                    IconColor = Color.White,
                    IconSize = 20,
                    ImageAlign = ContentAlignment.MiddleCenter,
                    Text = "",
                    Size = new Size(80, 60),
                    Dock = DockStyle.Right,
                    BackColor = blueColor,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Cursor = Cursors.Hand
                };

                var deleteButton = new IconButton
                {
                    IconChar = IconChar.Trash,
                    IconColor = Color.White,
                    IconSize = 20,
                    ImageAlign = ContentAlignment.MiddleCenter,
                    Text = "",
                    Size = new Size(80, 60),
                    Dock = DockStyle.Left,
                    BackColor = redColor,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Cursor = Cursors.Hand
                };

                var buttonPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 60,
                    Padding = new Padding(10),
                };

                buttonPanel.Controls.Add(editButton);
                buttonPanel.Controls.Add(deleteButton);

                var viewButton = new Button
                {
                    Text = "Ver detalles",
                    Font = new Font("Cambria", 15, FontStyle.Regular),
                    Dock = DockStyle.Bottom,
                    Height = 50,
                    BackColor = blueColor,
                    Tag = book,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Cursor = Cursors.Hand
                };

                viewButton.Click += (s, e) =>
                {
                    var clickedBook = (Book)((Button)s).Tag;
                    MessageBox.Show(, MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                cardPanel.Controls.Add(viewButton);
                cardPanel.Controls.Add(buttonPanel);
                cardPanel.Controls.Add(stateLabel);
                cardPanel.Controls.Add(categoryLabel);
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(coverPictureBox);

                FlpBooks.Controls.Add(cardPanel);
            }
        }
    }
}

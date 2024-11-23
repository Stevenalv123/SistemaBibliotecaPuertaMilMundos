namespace SistemaBiblioteca.Forms.BooksForm
{
    partial class AuthorsForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtSearch = new TextBox();
            lstAuthors = new ListBox();
            BtnAddAuthor = new FontAwesome.Sharp.IconButton();
            BtnUpdateAuthor = new FontAwesome.Sharp.IconButton();
            BtnDeleteAuthor = new FontAwesome.Sharp.IconButton();
            BtnReady = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            LblSelectedAuthors = new Label();
            BtnSearch = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // TxtSearch
            // 
            TxtSearch.Font = new Font("Segoe UI", 12F);
            TxtSearch.Location = new Point(12, 12);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Buscar autor";
            TxtSearch.Size = new Size(616, 29);
            TxtSearch.TabIndex = 0;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lstAuthors
            // 
            lstAuthors.Font = new Font("Cambria", 14F);
            lstAuthors.FormattingEnabled = true;
            lstAuthors.ItemHeight = 22;
            lstAuthors.Location = new Point(11, 62);
            lstAuthors.Name = "lstAuthors";
            lstAuthors.SelectionMode = SelectionMode.MultiExtended;
            lstAuthors.Size = new Size(477, 356);
            lstAuthors.TabIndex = 1;
            lstAuthors.SelectedIndexChanged += SelectedAuthor;
            // 
            // BtnAddAuthor
            // 
            BtnAddAuthor.BackColor = Color.FromArgb(40, 68, 131);
            BtnAddAuthor.Cursor = Cursors.Hand;
            BtnAddAuthor.FlatAppearance.BorderSize = 0;
            BtnAddAuthor.FlatStyle = FlatStyle.Flat;
            BtnAddAuthor.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnAddAuthor.ForeColor = Color.White;
            BtnAddAuthor.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtnAddAuthor.IconColor = Color.White;
            BtnAddAuthor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnAddAuthor.IconSize = 26;
            BtnAddAuthor.ImageAlign = ContentAlignment.TopLeft;
            BtnAddAuthor.Location = new Point(500, 62);
            BtnAddAuthor.Name = "BtnAddAuthor";
            BtnAddAuthor.Size = new Size(129, 32);
            BtnAddAuthor.TabIndex = 16;
            BtnAddAuthor.Text = "     Agregar autor";
            BtnAddAuthor.UseVisualStyleBackColor = false;
            BtnAddAuthor.Click += BtnAddAuthor_Click;
            // 
            // BtnUpdateAuthor
            // 
            BtnUpdateAuthor.Cursor = Cursors.Hand;
            BtnUpdateAuthor.Enabled = false;
            BtnUpdateAuthor.FlatAppearance.BorderSize = 0;
            BtnUpdateAuthor.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnUpdateAuthor.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnUpdateAuthor.IconColor = Color.FromArgb(40, 68, 131);
            BtnUpdateAuthor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnUpdateAuthor.IconSize = 26;
            BtnUpdateAuthor.ImageAlign = ContentAlignment.TopLeft;
            BtnUpdateAuthor.Location = new Point(499, 100);
            BtnUpdateAuthor.Name = "BtnUpdateAuthor";
            BtnUpdateAuthor.Size = new Size(129, 32);
            BtnUpdateAuthor.TabIndex = 16;
            BtnUpdateAuthor.Text = "Actualizar autor";
            BtnUpdateAuthor.TextAlign = ContentAlignment.MiddleRight;
            BtnUpdateAuthor.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteAuthor
            // 
            BtnDeleteAuthor.BackColor = Color.FromArgb(185, 27, 33);
            BtnDeleteAuthor.Cursor = Cursors.Hand;
            BtnDeleteAuthor.Enabled = false;
            BtnDeleteAuthor.FlatAppearance.BorderSize = 0;
            BtnDeleteAuthor.FlatStyle = FlatStyle.Flat;
            BtnDeleteAuthor.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnDeleteAuthor.ForeColor = Color.White;
            BtnDeleteAuthor.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnDeleteAuthor.IconColor = Color.White;
            BtnDeleteAuthor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnDeleteAuthor.IconSize = 26;
            BtnDeleteAuthor.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDeleteAuthor.Location = new Point(499, 138);
            BtnDeleteAuthor.Name = "BtnDeleteAuthor";
            BtnDeleteAuthor.Size = new Size(129, 34);
            BtnDeleteAuthor.TabIndex = 16;
            BtnDeleteAuthor.Text = "Eliminar autor  ";
            BtnDeleteAuthor.TextAlign = ContentAlignment.MiddleRight;
            BtnDeleteAuthor.UseVisualStyleBackColor = false;
            BtnDeleteAuthor.Click += BtnDeleteAuthor_Click;
            // 
            // BtnReady
            // 
            BtnReady.BackColor = Color.FromArgb(40, 68, 131);
            BtnReady.Cursor = Cursors.Hand;
            BtnReady.FlatAppearance.BorderSize = 0;
            BtnReady.FlatStyle = FlatStyle.Flat;
            BtnReady.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnReady.ForeColor = Color.White;
            BtnReady.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnReady.IconColor = Color.White;
            BtnReady.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnReady.IconSize = 26;
            BtnReady.ImageAlign = ContentAlignment.TopLeft;
            BtnReady.Location = new Point(499, 227);
            BtnReady.Name = "BtnReady";
            BtnReady.Size = new Size(129, 32);
            BtnReady.TabIndex = 18;
            BtnReady.Text = "Listo";
            BtnReady.UseVisualStyleBackColor = false;
            BtnReady.Visible = false;
            BtnReady.Click += BtnReady_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            label1.Location = new Point(11, 44);
            label1.Name = "label1";
            label1.Size = new Size(347, 13);
            label1.TabIndex = 19;
            label1.Text = "Puede seleccionar 1 o mas autores manteniendo presionada la tecla Ctrl";
            // 
            // LblSelectedAuthors
            // 
            LblSelectedAuthors.AutoSize = true;
            LblSelectedAuthors.Location = new Point(500, 262);
            LblSelectedAuthors.Name = "LblSelectedAuthors";
            LblSelectedAuthors.Size = new Size(0, 15);
            LblSelectedAuthors.TabIndex = 20;
            // 
            // BtnSearch
            // 
            BtnSearch.Cursor = Cursors.Hand;
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnSearch.IconColor = Color.Black;
            BtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSearch.IconSize = 24;
            BtnSearch.Location = new Point(590, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(29, 18);
            BtnSearch.TabIndex = 17;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // AuthorsForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(641, 439);
            Controls.Add(LblSelectedAuthors);
            Controls.Add(label1);
            Controls.Add(BtnReady);
            Controls.Add(BtnSearch);
            Controls.Add(BtnDeleteAuthor);
            Controls.Add(BtnUpdateAuthor);
            Controls.Add(BtnAddAuthor);
            Controls.Add(lstAuthors);
            Controls.Add(TxtSearch);
            MaximizeBox = false;
            MaximumSize = new Size(657, 478);
            MinimizeBox = false;
            MinimumSize = new Size(657, 478);
            Name = "AuthorsForms";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autores";
            Load += AuthorsForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSearch;
        private ListBox lstAuthors;
        private FontAwesome.Sharp.IconButton BtnAddAuthor;
        private FontAwesome.Sharp.IconButton BtnUpdateAuthor;
        private FontAwesome.Sharp.IconButton BtnDeleteAuthor;
        private FontAwesome.Sharp.IconButton BtnReady;
        private Label label1;
        private Label LblSelectedAuthors;
        private FontAwesome.Sharp.IconButton BtnSearch;
    }
}
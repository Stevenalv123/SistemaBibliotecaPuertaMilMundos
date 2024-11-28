namespace SistemaBiblioteca.Forms
{
    partial class MainFormBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormBooks));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ToolBoxUsers = new ToolStrip();
            BtnAddBook = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnPrint = new ToolStripButton();
            TopPanel = new Panel();
            SearchPanel = new Panel();
            pictureBox1 = new PictureBox();
            TxtSearch = new TextBox();
            UsernamePanel = new Panel();
            LblUsers = new Label();
            PrintDialogBooks = new PrintDialog();
            panel2 = new Panel();
            DtvBooks = new DataGridView();
            Cell_Title = new DataGridViewTextBoxColumn();
            Cell_Autor = new DataGridViewTextBoxColumn();
            Cell_Categorie = new DataGridViewTextBoxColumn();
            Cell_ISBN = new DataGridViewTextBoxColumn();
            Cell_Editorial = new DataGridViewTextBoxColumn();
            Cell_Year = new DataGridViewTextBoxColumn();
            Cell_Stock = new DataGridViewTextBoxColumn();
            Cell_State = new DataGridViewTextBoxColumn();
            Cell_Pages = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtvBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ToolBoxUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 42);
            panel1.TabIndex = 8;
            // 
            // ToolBoxUsers
            // 
            ToolBoxUsers.Dock = DockStyle.Fill;
            ToolBoxUsers.Items.AddRange(new ToolStripItem[] { BtnAddBook, toolStripSeparator1, BtnPrint });
            ToolBoxUsers.Location = new Point(0, 0);
            ToolBoxUsers.Name = "ToolBoxUsers";
            ToolBoxUsers.Size = new Size(931, 42);
            ToolBoxUsers.TabIndex = 0;
            ToolBoxUsers.Text = "toolStrip1";
            // 
            // BtnAddBook
            // 
            BtnAddBook.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnAddBook.Image = (Image)resources.GetObject("BtnAddBook.Image");
            BtnAddBook.ImageTransparentColor = Color.Magenta;
            BtnAddBook.Name = "BtnAddBook";
            BtnAddBook.Size = new Size(84, 39);
            BtnAddBook.Text = "Agregar";
            BtnAddBook.Click += AddNewBook;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // BtnPrint
            // 
            BtnPrint.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnPrint.Image = (Image)resources.GetObject("BtnPrint.Image");
            BtnPrint.ImageTransparentColor = Color.Magenta;
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(92, 39);
            BtnPrint.Text = "Imprimir";
            BtnPrint.Click += BtnPrint_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(40, 68, 131);
            TopPanel.Controls.Add(SearchPanel);
            TopPanel.Controls.Add(LblUsers);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(931, 70);
            TopPanel.TabIndex = 7;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(pictureBox1);
            SearchPanel.Controls.Add(TxtSearch);
            SearchPanel.Controls.Add(UsernamePanel);
            SearchPanel.Dock = DockStyle.Right;
            SearchPanel.Location = new Point(475, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(456, 70);
            SearchPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(58, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.FromArgb(40, 68, 131);
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Cursor = Cursors.IBeam;
            TxtSearch.Font = new Font("Cambria", 20F);
            TxtSearch.ForeColor = Color.White;
            TxtSearch.HideSelection = false;
            TxtSearch.Location = new Point(112, 18);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Buscar libro....";
            TxtSearch.Size = new Size(332, 32);
            TxtSearch.TabIndex = 11;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.White;
            UsernamePanel.Location = new Point(111, 50);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(332, 1);
            UsernamePanel.TabIndex = 12;
            // 
            // LblUsers
            // 
            LblUsers.AutoSize = true;
            LblUsers.Font = new Font("Cambria", 24F, FontStyle.Bold);
            LblUsers.ForeColor = Color.White;
            LblUsers.Location = new Point(12, 18);
            LblUsers.Name = "LblUsers";
            LblUsers.Size = new Size(112, 37);
            LblUsers.TabIndex = 2;
            LblUsers.Text = "Libros";
            // 
            // PrintDialogBooks
            // 
            PrintDialogBooks.UseEXDialog = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(DtvBooks);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 518);
            panel2.TabIndex = 9;
            // 
            // DtvBooks
            // 
            DtvBooks.AllowUserToAddRows = false;
            DtvBooks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveBorder;
            DtvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DtvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtvBooks.BackgroundColor = Color.White;
            DtvBooks.BorderStyle = BorderStyle.None;
            DtvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = "-";
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DtvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DtvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtvBooks.Columns.AddRange(new DataGridViewColumn[] { Cell_Title, Cell_Autor, Cell_Categorie, Cell_ISBN, Cell_Editorial, Cell_Year, Cell_Stock, Cell_State, Cell_Pages });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DtvBooks.DefaultCellStyle = dataGridViewCellStyle6;
            DtvBooks.Dock = DockStyle.Fill;
            DtvBooks.Location = new Point(0, 0);
            DtvBooks.MultiSelect = false;
            DtvBooks.Name = "DtvBooks";
            DtvBooks.ReadOnly = true;
            DtvBooks.RowHeadersVisible = false;
            DtvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtvBooks.Size = new Size(931, 518);
            DtvBooks.TabIndex = 4;
            // 
            // Cell_Title
            // 
            Cell_Title.HeaderText = "Titulo";
            Cell_Title.Name = "Cell_Title";
            Cell_Title.ReadOnly = true;
            // 
            // Cell_Autor
            // 
            Cell_Autor.HeaderText = "Autor";
            Cell_Autor.Name = "Cell_Autor";
            Cell_Autor.ReadOnly = true;
            // 
            // Cell_Categorie
            // 
            Cell_Categorie.HeaderText = "Categoria";
            Cell_Categorie.Name = "Cell_Categorie";
            Cell_Categorie.ReadOnly = true;
            // 
            // Cell_ISBN
            // 
            Cell_ISBN.HeaderText = "ISBN";
            Cell_ISBN.Name = "Cell_ISBN";
            Cell_ISBN.ReadOnly = true;
            // 
            // Cell_Editorial
            // 
            Cell_Editorial.HeaderText = "Editorial";
            Cell_Editorial.Name = "Cell_Editorial";
            Cell_Editorial.ReadOnly = true;
            // 
            // Cell_Year
            // 
            Cell_Year.HeaderText = "Año de publicacion";
            Cell_Year.Name = "Cell_Year";
            Cell_Year.ReadOnly = true;
            // 
            // Cell_Stock
            // 
            Cell_Stock.HeaderText = "Stock";
            Cell_Stock.Name = "Cell_Stock";
            Cell_Stock.ReadOnly = true;
            // 
            // Cell_State
            // 
            Cell_State.HeaderText = "Estado";
            Cell_State.Name = "Cell_State";
            Cell_State.ReadOnly = true;
            // 
            // Cell_Pages
            // 
            Cell_Pages.HeaderText = "Paginas";
            Cell_Pages.Name = "Cell_Pages";
            Cell_Pages.ReadOnly = true;
            // 
            // MainFormBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 630);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            KeyPreview = true;
            Name = "MainFormBooks";
            Text = "Books";
            Load += MainFormBooks_Load;
            KeyDown += MainFormBooks_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ToolBoxUsers.ResumeLayout(false);
            ToolBoxUsers.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ToolStrip ToolBoxUsers;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnPrint;
        private Panel TopPanel;
        private Panel SearchPanel;
        private Label LblUsers;
        private PictureBox pictureBox1;
        private TextBox TxtSearch;
        private Panel UsernamePanel;
        private PrintDialog PrintDialogBooks;
        private ToolStripButton BtnAddBook;
        private Panel panel2;
        private DataGridView DtvBooks;
        private DataGridViewTextBoxColumn Cell_Title;
        private DataGridViewTextBoxColumn Cell_Autor;
        private DataGridViewTextBoxColumn Cell_Categorie;
        private DataGridViewTextBoxColumn Cell_ISBN;
        private DataGridViewTextBoxColumn Cell_Editorial;
        private DataGridViewTextBoxColumn Cell_Year;
        private DataGridViewTextBoxColumn Cell_Stock;
        private DataGridViewTextBoxColumn Cell_State;
        private DataGridViewTextBoxColumn Cell_Pages;
    }
}
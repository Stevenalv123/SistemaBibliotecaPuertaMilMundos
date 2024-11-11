namespace SistemaBiblioteca.Forms.DevolutionsForms
{
    partial class DevolutionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolutionForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            TopPanel = new Panel();
            SearchPanel = new Panel();
            pictureBox1 = new PictureBox();
            TxtSearch = new TextBox();
            UsernamePanel = new Panel();
            LblUsers = new Label();
            panel1 = new Panel();
            ToolBoxUsers = new ToolStrip();
            BtnAddBook = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            BtnEdit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnPrint = new ToolStripButton();
            panel2 = new Panel();
            panel3 = new Panel();
            StatusStripBooks = new StatusStrip();
            BtnMessage = new FontAwesome.Sharp.IconDropDownButton();
            MessageReady = new ToolStripMenuItem();
            LblMessage = new ToolStripStatusLabel();
            dtgBooks = new DataGridView();
            Cell_ID = new DataGridViewTextBoxColumn();
            Cell_Title = new DataGridViewTextBoxColumn();
            Cell_Autor = new DataGridViewTextBoxColumn();
            Cell_ISBN = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Cell_Editorial = new DataGridViewTextBoxColumn();
            Cell_Year = new DataGridViewTextBoxColumn();
            Cell_Quantity = new DataGridViewTextBoxColumn();
            Cell_State = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            StatusStripBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(931, 630);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(TopPanel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 602);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 602);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(40, 68, 131);
            TopPanel.Controls.Add(SearchPanel);
            TopPanel.Controls.Add(LblUsers);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(3, 3);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(917, 70);
            TopPanel.TabIndex = 8;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(pictureBox1);
            SearchPanel.Controls.Add(TxtSearch);
            SearchPanel.Controls.Add(UsernamePanel);
            SearchPanel.Dock = DockStyle.Right;
            SearchPanel.Location = new Point(461, 0);
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
            // panel1
            // 
            panel1.Controls.Add(ToolBoxUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 50);
            panel1.TabIndex = 9;
            // 
            // ToolBoxUsers
            // 
            ToolBoxUsers.Dock = DockStyle.Fill;
            ToolBoxUsers.Items.AddRange(new ToolStripItem[] { BtnAddBook, toolStripSeparator3, BtnEdit, toolStripSeparator1, BtnDelete, toolStripSeparator2, BtnPrint });
            ToolBoxUsers.Location = new Point(0, 0);
            ToolBoxUsers.Name = "ToolBoxUsers";
            ToolBoxUsers.Size = new Size(917, 50);
            ToolBoxUsers.TabIndex = 1;
            ToolBoxUsers.Text = "toolStrip1";
            // 
            // BtnAddBook
            // 
            BtnAddBook.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnAddBook.Image = (Image)resources.GetObject("BtnAddBook.Image");
            BtnAddBook.ImageTransparentColor = Color.Magenta;
            BtnAddBook.Name = "BtnAddBook";
            BtnAddBook.Size = new Size(84, 47);
            BtnAddBook.Text = "Agregar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 50);
            // 
            // BtnEdit
            // 
            BtnEdit.Enabled = false;
            BtnEdit.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.ImageTransparentColor = Color.Magenta;
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(71, 47);
            BtnEdit.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 50);
            // 
            // BtnDelete
            // 
            BtnDelete.Enabled = false;
            BtnDelete.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.ImageTransparentColor = Color.Magenta;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(89, 47);
            BtnDelete.Text = "Eliminar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 50);
            // 
            // BtnPrint
            // 
            BtnPrint.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnPrint.Image = (Image)resources.GetObject("BtnPrint.Image");
            BtnPrint.ImageTransparentColor = Color.Magenta;
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(92, 47);
            BtnPrint.Text = "Imprimir";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgBooks);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(917, 436);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(StatusStripBooks);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 559);
            panel3.Name = "panel3";
            panel3.Size = new Size(917, 40);
            panel3.TabIndex = 11;
            // 
            // StatusStripBooks
            // 
            StatusStripBooks.BackColor = Color.FromArgb(40, 68, 131);
            StatusStripBooks.Dock = DockStyle.Fill;
            StatusStripBooks.Items.AddRange(new ToolStripItem[] { BtnMessage, LblMessage });
            StatusStripBooks.Location = new Point(0, 0);
            StatusStripBooks.Name = "StatusStripBooks";
            StatusStripBooks.Size = new Size(917, 40);
            StatusStripBooks.TabIndex = 5;
            StatusStripBooks.Text = "statusStrip1";
            // 
            // BtnMessage
            // 
            BtnMessage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnMessage.DropDownItems.AddRange(new ToolStripItem[] { MessageReady });
            BtnMessage.IconChar = FontAwesome.Sharp.IconChar.Message;
            BtnMessage.IconColor = Color.White;
            BtnMessage.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnMessage.ImageTransparentColor = Color.Magenta;
            BtnMessage.Name = "BtnMessage";
            BtnMessage.Size = new Size(29, 38);
            BtnMessage.Text = "Listo";
            // 
            // MessageReady
            // 
            MessageReady.BackColor = Color.White;
            MessageReady.ForeColor = Color.Black;
            MessageReady.Name = "MessageReady";
            MessageReady.Size = new Size(132, 22);
            MessageReady.Text = "¡Todo listo!";
            // 
            // LblMessage
            // 
            LblMessage.ForeColor = Color.White;
            LblMessage.Name = "LblMessage";
            LblMessage.Size = new Size(32, 35);
            LblMessage.Text = "Listo";
            // 
            // dtgBooks
            // 
            dtgBooks.AllowUserToAddRows = false;
            dtgBooks.AllowUserToDeleteRows = false;
            dtgBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBooks.BackgroundColor = Color.White;
            dtgBooks.BorderStyle = BorderStyle.None;
            dtgBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBooks.Columns.AddRange(new DataGridViewColumn[] { Cell_ID, Cell_Title, Cell_Autor, Cell_ISBN, Categorie, Cell_Editorial, Cell_Year, Cell_Quantity, Cell_State });
            dtgBooks.Dock = DockStyle.Fill;
            dtgBooks.Location = new Point(0, 0);
            dtgBooks.Name = "dtgBooks";
            dtgBooks.ReadOnly = true;
            dtgBooks.RowHeadersVisible = false;
            dtgBooks.Size = new Size(917, 436);
            dtgBooks.TabIndex = 4;
            // 
            // Cell_ID
            // 
            Cell_ID.HeaderText = "ID";
            Cell_ID.Name = "Cell_ID";
            Cell_ID.ReadOnly = true;
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
            // Cell_ISBN
            // 
            Cell_ISBN.HeaderText = "ISBN";
            Cell_ISBN.Name = "Cell_ISBN";
            Cell_ISBN.ReadOnly = true;
            // 
            // Categorie
            // 
            Categorie.HeaderText = "Categorias";
            Categorie.Name = "Categorie";
            Categorie.ReadOnly = true;
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
            // Cell_Quantity
            // 
            Cell_Quantity.HeaderText = "Stock";
            Cell_Quantity.Name = "Cell_Quantity";
            Cell_Quantity.ReadOnly = true;
            // 
            // Cell_State
            // 
            Cell_State.HeaderText = "Estado";
            Cell_State.Name = "Cell_State";
            Cell_State.ReadOnly = true;
            // 
            // DevolutionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 630);
            Controls.Add(tabControl1);
            Name = "DevolutionForm";
            Text = "DevolutionForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ToolBoxUsers.ResumeLayout(false);
            ToolBoxUsers.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            StatusStripBooks.ResumeLayout(false);
            StatusStripBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel TopPanel;
        private Panel SearchPanel;
        private PictureBox pictureBox1;
        private TextBox TxtSearch;
        private Panel UsernamePanel;
        private Label LblUsers;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private ToolStrip ToolBoxUsers;
        private ToolStripButton BtnAddBook;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BtnEdit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnPrint;
        private StatusStrip StatusStripBooks;
        private FontAwesome.Sharp.IconDropDownButton BtnMessage;
        private ToolStripMenuItem MessageReady;
        private ToolStripStatusLabel LblMessage;
        private DataGridView dtgBooks;
        private DataGridViewTextBoxColumn Cell_ID;
        private DataGridViewTextBoxColumn Cell_Title;
        private DataGridViewTextBoxColumn Cell_Autor;
        private DataGridViewTextBoxColumn Cell_ISBN;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Cell_Editorial;
        private DataGridViewTextBoxColumn Cell_Year;
        private DataGridViewTextBoxColumn Cell_Quantity;
        private DataGridViewTextBoxColumn Cell_State;
    }
}
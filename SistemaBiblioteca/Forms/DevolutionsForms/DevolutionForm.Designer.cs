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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolutionForm));
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            DtvLoans = new DataGridView();
            Cell_Codigo = new DataGridViewTextBoxColumn();
            Cell_Student = new DataGridViewTextBoxColumn();
            Cell_Book = new DataGridViewTextBoxColumn();
            Cell_LoanDate = new DataGridViewTextBoxColumn();
            Cell_LoanDevolutiondate = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ToolBoxUsers = new ToolStrip();
            BtnAddBook = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            BtnEdit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnPrint = new ToolStripButton();
            TopPanel = new Panel();
            label2 = new Label();
            SearchPanel = new Panel();
            pictureBox1 = new PictureBox();
            TxtSearch = new TextBox();
            UsernamePanel = new Panel();
            tabPage2 = new TabPage();
            panel7 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            panel4 = new Panel();
            LblUsers = new Label();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            panel6 = new Panel();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtvLoans).BeginInit();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            panel7.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 630);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Cambria", 14F, FontStyle.Bold);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(931, 630);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(TopPanel);
            tabPage1.Font = new Font("Cambria", 14F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 595);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Prestamos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(DtvLoans);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(917, 473);
            panel3.TabIndex = 10;
            // 
            // DtvLoans
            // 
            DtvLoans.AllowUserToAddRows = false;
            DtvLoans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveBorder;
            DtvLoans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DtvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtvLoans.BackgroundColor = Color.White;
            DtvLoans.BorderStyle = BorderStyle.None;
            DtvLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DtvLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DtvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtvLoans.Columns.AddRange(new DataGridViewColumn[] { Cell_Codigo, Cell_Student, Cell_Book, Cell_LoanDate, Cell_LoanDevolutiondate });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DtvLoans.DefaultCellStyle = dataGridViewCellStyle3;
            DtvLoans.Dock = DockStyle.Fill;
            DtvLoans.Location = new Point(0, 0);
            DtvLoans.MultiSelect = false;
            DtvLoans.Name = "DtvLoans";
            DtvLoans.ReadOnly = true;
            DtvLoans.RowHeadersVisible = false;
            DtvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtvLoans.Size = new Size(917, 473);
            DtvLoans.TabIndex = 5;
            // 
            // Cell_Codigo
            // 
            Cell_Codigo.HeaderText = "Codigo";
            Cell_Codigo.Name = "Cell_Codigo";
            Cell_Codigo.ReadOnly = true;
            // 
            // Cell_Student
            // 
            Cell_Student.HeaderText = "Estudiante";
            Cell_Student.Name = "Cell_Student";
            Cell_Student.ReadOnly = true;
            // 
            // Cell_Book
            // 
            Cell_Book.HeaderText = "Libro";
            Cell_Book.Name = "Cell_Book";
            Cell_Book.ReadOnly = true;
            // 
            // Cell_LoanDate
            // 
            Cell_LoanDate.HeaderText = "Fecha de Prestamo";
            Cell_LoanDate.Name = "Cell_LoanDate";
            Cell_LoanDate.ReadOnly = true;
            // 
            // Cell_LoanDevolutiondate
            // 
            Cell_LoanDevolutiondate.HeaderText = "Fecha de devolucion";
            Cell_LoanDevolutiondate.Name = "Cell_LoanDevolutiondate";
            Cell_LoanDevolutiondate.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ToolBoxUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 46);
            panel1.TabIndex = 9;
            // 
            // ToolBoxUsers
            // 
            ToolBoxUsers.Dock = DockStyle.Fill;
            ToolBoxUsers.ImageScalingSize = new Size(20, 20);
            ToolBoxUsers.Items.AddRange(new ToolStripItem[] { BtnAddBook, toolStripSeparator3, BtnEdit, toolStripSeparator1, BtnDelete, toolStripSeparator2, BtnPrint });
            ToolBoxUsers.Location = new Point(0, 0);
            ToolBoxUsers.Name = "ToolBoxUsers";
            ToolBoxUsers.Size = new Size(917, 46);
            ToolBoxUsers.TabIndex = 1;
            ToolBoxUsers.Text = "toolStrip1";
            // 
            // BtnAddBook
            // 
            BtnAddBook.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnAddBook.Image = (Image)resources.GetObject("BtnAddBook.Image");
            BtnAddBook.ImageTransparentColor = Color.Magenta;
            BtnAddBook.Name = "BtnAddBook";
            BtnAddBook.Size = new Size(88, 43);
            BtnAddBook.Text = "Agregar";
            BtnAddBook.Click += BtnAddBook_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 46);
            // 
            // BtnEdit
            // 
            BtnEdit.Enabled = false;
            BtnEdit.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.ImageTransparentColor = Color.Magenta;
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 43);
            BtnEdit.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 46);
            // 
            // BtnDelete
            // 
            BtnDelete.Enabled = false;
            BtnDelete.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.ImageTransparentColor = Color.Magenta;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(93, 43);
            BtnDelete.Text = "Eliminar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 46);
            // 
            // BtnPrint
            // 
            BtnPrint.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnPrint.Image = (Image)resources.GetObject("BtnPrint.Image");
            BtnPrint.ImageTransparentColor = Color.Magenta;
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(96, 43);
            BtnPrint.Text = "Imprimir";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(40, 68, 131);
            TopPanel.Controls.Add(label2);
            TopPanel.Controls.Add(SearchPanel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(3, 3);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(917, 70);
            TopPanel.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 13);
            label2.Name = "label2";
            label2.Size = new Size(174, 37);
            label2.TabIndex = 4;
            label2.Text = "Prestamos";
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
            TxtSearch.PlaceholderText = "Buscar registro";
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
            // tabPage2
            // 
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 602);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Devoluciones";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(toolStrip1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 73);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(917, 50);
            panel7.TabIndex = 10;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator4, toolStripButton2, toolStripSeparator5, toolStripButton3, toolStripSeparator6, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(917, 50);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(88, 47);
            toolStripButton1.Text = "Agregar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 50);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Enabled = false;
            toolStripButton2.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(75, 47);
            toolStripButton2.Text = "Editar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 50);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Enabled = false;
            toolStripButton3.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(93, 47);
            toolStripButton3.Text = "Eliminar";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 50);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(96, 47);
            toolStripButton4.Text = "Imprimir";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 68, 131);
            panel4.Controls.Add(LblUsers);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(917, 70);
            panel4.TabIndex = 9;
            // 
            // LblUsers
            // 
            LblUsers.AutoSize = true;
            LblUsers.Font = new Font("Cambria", 24F, FontStyle.Bold);
            LblUsers.ForeColor = Color.White;
            LblUsers.Location = new Point(5, 17);
            LblUsers.Name = "LblUsers";
            LblUsers.Size = new Size(213, 37);
            LblUsers.TabIndex = 14;
            LblUsers.Text = "Devoluciones";
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(461, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(456, 70);
            panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(58, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(40, 68, 131);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Cambria", 20F);
            textBox1.ForeColor = Color.White;
            textBox1.HideSelection = false;
            textBox1.Location = new Point(112, 18);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar registro";
            textBox1.Size = new Size(332, 32);
            textBox1.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(111, 50);
            panel6.Name = "panel6";
            panel6.Size = new Size(332, 1);
            panel6.TabIndex = 12;
            // 
            // DevolutionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 630);
            Controls.Add(panel2);
            Name = "DevolutionForm";
            Text = "DevolutionForm";
            Load += DevolutionForm_Load;
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtvLoans).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ToolBoxUsers.ResumeLayout(false);
            ToolBoxUsers.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private ToolStrip ToolBoxUsers;
        private ToolStripButton BtnAddBook;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BtnEdit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnPrint;
        private Panel TopPanel;
        private Panel SearchPanel;
        private PictureBox pictureBox1;
        private TextBox TxtSearch;
        private Panel UsernamePanel;
        private TabPage tabPage2;
        private Panel panel7;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton4;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Panel panel6;
        private Label label2;
        private Label LblUsers;
        private Panel panel3;
        private DataGridView DtvLoans;
        private DataGridViewTextBoxColumn Cell_Codigo;
        private DataGridViewTextBoxColumn Cell_Student;
        private DataGridViewTextBoxColumn Cell_Book;
        private DataGridViewTextBoxColumn Cell_LoanDate;
        private DataGridViewTextBoxColumn Cell_LoanDevolutiondate;
    }
}
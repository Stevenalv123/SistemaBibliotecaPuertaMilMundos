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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolutionForm));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel2 = new Panel();
            TbDevolutions = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            DtvLoans = new DataGridView();
            Cell_Codigo = new DataGridViewTextBoxColumn();
            Cell_Student = new DataGridViewTextBoxColumn();
            Cell_Book = new DataGridViewTextBoxColumn();
            Cell_LoanDate = new DataGridViewTextBoxColumn();
            Cell_LoanDevolutiondate = new DataGridViewTextBoxColumn();
            Cell_Observations = new DataGridViewTextBoxColumn();
            Cell_State = new DataGridViewTextBoxColumn();
            Cell_Fine = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ToolBoxUsers = new ToolStrip();
            BtnNewRegister = new ToolStripButton();
            BtnPrint = new ToolStripButton();
            TopPanel = new Panel();
            label2 = new Label();
            SearchPanel = new Panel();
            pictureBox1 = new PictureBox();
            TxtSearch = new TextBox();
            UsernamePanel = new Panel();
            tabPage2 = new TabPage();
            panel8 = new Panel();
            DtvDevoluciones = new DataGridView();
            Cell_Code = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton4 = new ToolStripButton();
            panel6 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel2.SuspendLayout();
            TbDevolutions.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtvLoans).BeginInit();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtvDevoluciones).BeginInit();
            panel7.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(TbDevolutions);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 630);
            panel2.TabIndex = 1;
            // 
            // TbDevolutions
            // 
            TbDevolutions.Controls.Add(tabPage1);
            TbDevolutions.Controls.Add(tabPage2);
            TbDevolutions.Dock = DockStyle.Fill;
            TbDevolutions.Font = new Font("Cambria", 14F, FontStyle.Bold);
            TbDevolutions.Location = new Point(0, 0);
            TbDevolutions.Name = "TbDevolutions";
            TbDevolutions.SelectedIndex = 0;
            TbDevolutions.Size = new Size(931, 630);
            TbDevolutions.TabIndex = 1;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ActiveBorder;
            DtvLoans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            DtvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtvLoans.BackgroundColor = Color.White;
            DtvLoans.BorderStyle = BorderStyle.None;
            DtvLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.NullValue = "-";
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DtvLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DtvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtvLoans.Columns.AddRange(new DataGridViewColumn[] { Cell_Codigo, Cell_Student, Cell_Book, Cell_LoanDate, Cell_LoanDevolutiondate, Cell_Observations, Cell_State, Cell_Fine });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle9.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DtvLoans.DefaultCellStyle = dataGridViewCellStyle9;
            DtvLoans.Dock = DockStyle.Fill;
            DtvLoans.Location = new Point(0, 0);
            DtvLoans.MultiSelect = false;
            DtvLoans.Name = "DtvLoans";
            DtvLoans.ReadOnly = true;
            DtvLoans.RowHeadersVisible = false;
            DtvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtvLoans.Size = new Size(917, 473);
            DtvLoans.TabIndex = 5;
            DtvLoans.CellClick += DtvLoans_CellClick;
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
            // Cell_Observations
            // 
            Cell_Observations.HeaderText = "Observaciones";
            Cell_Observations.Name = "Cell_Observations";
            Cell_Observations.ReadOnly = true;
            // 
            // Cell_State
            // 
            Cell_State.HeaderText = "Estado";
            Cell_State.Name = "Cell_State";
            Cell_State.ReadOnly = true;
            // 
            // Cell_Fine
            // 
            Cell_Fine.HeaderText = "Valor de multa";
            Cell_Fine.Name = "Cell_Fine";
            Cell_Fine.ReadOnly = true;
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
            ToolBoxUsers.Items.AddRange(new ToolStripItem[] { BtnNewRegister, BtnPrint });
            ToolBoxUsers.Location = new Point(0, 0);
            ToolBoxUsers.Name = "ToolBoxUsers";
            ToolBoxUsers.Size = new Size(917, 46);
            ToolBoxUsers.TabIndex = 1;
            ToolBoxUsers.Text = "toolStrip1";
            // 
            // BtnNewRegister
            // 
            BtnNewRegister.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnNewRegister.Image = (Image)resources.GetObject("BtnNewRegister.Image");
            BtnNewRegister.ImageTransparentColor = Color.Magenta;
            BtnNewRegister.Name = "BtnNewRegister";
            BtnNewRegister.Size = new Size(76, 43);
            BtnNewRegister.Text = "Nuevo";
            BtnNewRegister.Click += BtnAddBook_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.Alignment = ToolStripItemAlignment.Right;
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
            tabPage2.Controls.Add(panel8);
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(panel6);
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 595);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Devoluciones";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(DtvDevoluciones);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 120);
            panel8.Name = "panel8";
            panel8.Size = new Size(917, 472);
            panel8.TabIndex = 11;
            // 
            // DtvDevoluciones
            // 
            DtvDevoluciones.AllowUserToAddRows = false;
            DtvDevoluciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ActiveBorder;
            DtvDevoluciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            DtvDevoluciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtvDevoluciones.BackgroundColor = Color.White;
            DtvDevoluciones.BorderStyle = BorderStyle.None;
            DtvDevoluciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Cambria", 14F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.NullValue = "-";
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            DtvDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            DtvDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtvDevoluciones.Columns.AddRange(new DataGridViewColumn[] { Cell_Code, Column2, Column1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column3 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle12.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            DtvDevoluciones.DefaultCellStyle = dataGridViewCellStyle12;
            DtvDevoluciones.Dock = DockStyle.Fill;
            DtvDevoluciones.Location = new Point(0, 0);
            DtvDevoluciones.MultiSelect = false;
            DtvDevoluciones.Name = "DtvDevoluciones";
            DtvDevoluciones.ReadOnly = true;
            DtvDevoluciones.RowHeadersVisible = false;
            DtvDevoluciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtvDevoluciones.Size = new Size(917, 472);
            DtvDevoluciones.TabIndex = 6;
            // 
            // Cell_Code
            // 
            Cell_Code.HeaderText = "Codigo de Prestamo";
            Cell_Code.Name = "Cell_Code";
            Cell_Code.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Libro";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Estudiante";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Fecha de devolucion";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Estado";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Multa";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(toolStrip1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 73);
            panel7.Name = "panel7";
            panel7.Size = new Size(917, 47);
            panel7.TabIndex = 10;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(917, 47);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(96, 44);
            toolStripButton4.Text = "Imprimir";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(40, 68, 131);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(panel5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(917, 70);
            panel6.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 13);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 4;
            label1.Text = "Devoluciones";
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(panel4);
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(111, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 1);
            panel4.TabIndex = 12;
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
            TbDevolutions.ResumeLayout(false);
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
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtvDevoluciones).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TabControl TbDevolutions;
        private TabPage tabPage1;
        private Panel panel1;
        private ToolStrip ToolBoxUsers;
        private ToolStripButton BtnNewRegister;
        private ToolStripButton BtnPrint;
        private Panel TopPanel;
        private Panel SearchPanel;
        private PictureBox pictureBox1;
        private TextBox TxtSearch;
        private Panel UsernamePanel;
        private Label label2;
        private Panel panel3;
        private DataGridView DtvLoans;
        private DataGridViewTextBoxColumn Cell_Codigo;
        private DataGridViewTextBoxColumn Cell_Student;
        private DataGridViewTextBoxColumn Cell_Book;
        private DataGridViewTextBoxColumn Cell_LoanDate;
        private DataGridViewTextBoxColumn Cell_LoanDevolutiondate;
        private DataGridViewTextBoxColumn Cell_Observations;
        private DataGridViewTextBoxColumn Cell_State;
        private DataGridViewTextBoxColumn Cell_Fine;
        private TabPage tabPage2;
        private Panel panel7;
        private Panel panel6;
        private Label label1;
        private Panel panel5;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Panel panel4;
        private Panel panel8;
        private DataGridView DtvDevoluciones;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton4;
        private DataGridViewTextBoxColumn Cell_Code;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column3;
    }
}
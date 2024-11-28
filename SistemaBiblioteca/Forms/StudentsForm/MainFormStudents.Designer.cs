namespace SistemaBiblioteca.Forms
{
    partial class MainFormStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormStudents));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            SearchPanel = new Panel();
            pictureBox1 = new PictureBox();
            UsernamePanel = new Panel();
            TxtSearch = new TextBox();
            LblStudents = new Label();
            panel1 = new Panel();
            ToolBoxUsers = new ToolStrip();
            TsbAddStudent = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            BtnEdit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnPrint = new ToolStripButton();
            MainPanel = new Panel();
            DtvStudents = new DataGridView();
            Cell_Carnet = new DataGridViewTextBoxColumn();
            Cell_Name = new DataGridViewTextBoxColumn();
            Cell_Adress = new DataGridViewTextBoxColumn();
            Cell_PhoneNumber = new DataGridViewTextBoxColumn();
            Cell_Email = new DataGridViewTextBoxColumn();
            Cell_Carrer = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtvStudents).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(40, 68, 131);
            TopPanel.Controls.Add(SearchPanel);
            TopPanel.Controls.Add(LblStudents);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(931, 70);
            TopPanel.TabIndex = 0;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(pictureBox1);
            SearchPanel.Controls.Add(UsernamePanel);
            SearchPanel.Controls.Add(TxtSearch);
            SearchPanel.Dock = DockStyle.Right;
            SearchPanel.Location = new Point(475, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(456, 70);
            SearchPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(58, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.White;
            UsernamePanel.Location = new Point(111, 49);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(332, 1);
            UsernamePanel.TabIndex = 8;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.FromArgb(40, 68, 131);
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Cursor = Cursors.IBeam;
            TxtSearch.Font = new Font("Cambria", 20F);
            TxtSearch.ForeColor = Color.White;
            TxtSearch.HideSelection = false;
            TxtSearch.Location = new Point(112, 17);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Buscar estudiante....";
            TxtSearch.Size = new Size(332, 32);
            TxtSearch.TabIndex = 4;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // LblStudents
            // 
            LblStudents.AutoSize = true;
            LblStudents.Font = new Font("Cambria", 24F, FontStyle.Bold);
            LblStudents.ForeColor = Color.White;
            LblStudents.Location = new Point(12, 18);
            LblStudents.Name = "LblStudents";
            LblStudents.Size = new Size(190, 37);
            LblStudents.TabIndex = 2;
            LblStudents.Text = "Estudiantes";
            // 
            // panel1
            // 
            panel1.Controls.Add(ToolBoxUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 42);
            panel1.TabIndex = 4;
            // 
            // ToolBoxUsers
            // 
            ToolBoxUsers.Dock = DockStyle.Fill;
            ToolBoxUsers.Items.AddRange(new ToolStripItem[] { TsbAddStudent, toolStripSeparator3, BtnEdit, toolStripSeparator1, BtnDelete, toolStripSeparator2, BtnPrint });
            ToolBoxUsers.Location = new Point(0, 0);
            ToolBoxUsers.Name = "ToolBoxUsers";
            ToolBoxUsers.Size = new Size(931, 42);
            ToolBoxUsers.TabIndex = 0;
            ToolBoxUsers.Text = "toolStrip1";
            // 
            // TsbAddStudent
            // 
            TsbAddStudent.Font = new Font("Cambria", 11F, FontStyle.Bold);
            TsbAddStudent.Image = (Image)resources.GetObject("TsbAddStudent.Image");
            TsbAddStudent.ImageTransparentColor = Color.Magenta;
            TsbAddStudent.Name = "TsbAddStudent";
            TsbAddStudent.Size = new Size(72, 39);
            TsbAddStudent.Text = "Nuevo";
            TsbAddStudent.Click += BtnAddStudent_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 42);
            // 
            // BtnEdit
            // 
            BtnEdit.Enabled = false;
            BtnEdit.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.ImageTransparentColor = Color.Magenta;
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(71, 39);
            BtnEdit.Text = "Editar";
            BtnEdit.Click += BtnEdit_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // BtnDelete
            // 
            BtnDelete.Enabled = false;
            BtnDelete.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.ImageTransparentColor = Color.Magenta;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(89, 39);
            BtnDelete.Text = "Eliminar";
            BtnDelete.Click += BtnDelete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 42);
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
            // MainPanel
            // 
            MainPanel.Controls.Add(DtvStudents);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 112);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(2);
            MainPanel.Size = new Size(931, 518);
            MainPanel.TabIndex = 6;
            // 
            // DtvStudents
            // 
            DtvStudents.AllowUserToAddRows = false;
            DtvStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveBorder;
            DtvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DtvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtvStudents.BackgroundColor = Color.White;
            DtvStudents.BorderStyle = BorderStyle.None;
            DtvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DtvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DtvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtvStudents.Columns.AddRange(new DataGridViewColumn[] { Cell_Carnet, Cell_Name, Cell_Adress, Cell_PhoneNumber, Cell_Email, Cell_Carrer });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DtvStudents.DefaultCellStyle = dataGridViewCellStyle3;
            DtvStudents.Dock = DockStyle.Fill;
            DtvStudents.Location = new Point(2, 2);
            DtvStudents.MultiSelect = false;
            DtvStudents.Name = "DtvStudents";
            DtvStudents.ReadOnly = true;
            DtvStudents.RowHeadersVisible = false;
            DtvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtvStudents.Size = new Size(927, 514);
            DtvStudents.TabIndex = 3;
            DtvStudents.SelectionChanged += DtvStudents_SelectionChanged;
            // 
            // Cell_Carnet
            // 
            Cell_Carnet.HeaderText = "Carnet";
            Cell_Carnet.Name = "Cell_Carnet";
            Cell_Carnet.ReadOnly = true;
            // 
            // Cell_Name
            // 
            Cell_Name.HeaderText = "Nombre";
            Cell_Name.Name = "Cell_Name";
            Cell_Name.ReadOnly = true;
            // 
            // Cell_Adress
            // 
            Cell_Adress.HeaderText = "Direccion";
            Cell_Adress.Name = "Cell_Adress";
            Cell_Adress.ReadOnly = true;
            // 
            // Cell_PhoneNumber
            // 
            Cell_PhoneNumber.HeaderText = "Telefono";
            Cell_PhoneNumber.Name = "Cell_PhoneNumber";
            Cell_PhoneNumber.ReadOnly = true;
            // 
            // Cell_Email
            // 
            Cell_Email.HeaderText = "Correo Electronico";
            Cell_Email.Name = "Cell_Email";
            Cell_Email.ReadOnly = true;
            // 
            // Cell_Carrer
            // 
            Cell_Carrer.HeaderText = "Carrera";
            Cell_Carrer.Name = "Cell_Carrer";
            Cell_Carrer.ReadOnly = true;
            // 
            // MainFormStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(931, 630);
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            KeyPreview = true;
            Name = "MainFormStudents";
            Text = "Users";
            Load += MainFormStudents_Load;
            KeyDown += MainFormStudents_KeyDown;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ToolBoxUsers.ResumeLayout(false);
            ToolBoxUsers.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private TextBox TxtSearch;
        private Label LblStudents;
        private Panel UsernamePanel;
        private Panel SearchPanel;
        private Panel panel1;
        private ToolStrip ToolBoxUsers;
        private ToolStripButton BtnEdit;
        private Panel MainPanel;
        private DataGridView DtvStudents;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnPrint;
        private PictureBox pictureBox1;
        private ToolStripButton TsbAddStudent;
        private ToolStripSeparator toolStripSeparator3;
        private DataGridViewTextBoxColumn Cell_Carnet;
        private DataGridViewTextBoxColumn Cell_Name;
        private DataGridViewTextBoxColumn Cell_Adress;
        private DataGridViewTextBoxColumn Cell_PhoneNumber;
        private DataGridViewTextBoxColumn Cell_Email;
        private DataGridViewTextBoxColumn Cell_Carrer;
    }
}
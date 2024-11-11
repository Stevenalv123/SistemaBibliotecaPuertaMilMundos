namespace SistemaBiblioteca.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            SearchPanel = new Panel();
            pictureBox1 = new PictureBox();
            UsernamePanel = new Panel();
            TxtSearch = new TextBox();
            LblUsers = new Label();
            panel1 = new Panel();
            ToolBoxUsers = new ToolStrip();
            BtnEdit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnPrint = new ToolStripButton();
            BottomPanel = new Panel();
            statusStrip1 = new StatusStrip();
            BtnMessage = new FontAwesome.Sharp.IconDropDownButton();
            MessageReady = new ToolStripMenuItem();
            LblMessage = new ToolStripStatusLabel();
            MainPanel = new Panel();
            dtgUsers = new DataGridView();
            Cell_ID = new DataGridViewTextBoxColumn();
            Cell_Name = new DataGridViewTextBoxColumn();
            Cell_Adress = new DataGridViewTextBoxColumn();
            Cell_PhoneNumber = new DataGridViewTextBoxColumn();
            Cell_Email = new DataGridViewTextBoxColumn();
            Cell_DNI = new DataGridViewTextBoxColumn();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            BottomPanel.SuspendLayout();
            statusStrip1.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsers).BeginInit();
            SuspendLayout();
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
            TxtSearch.PlaceholderText = "Buscar usuario....";
            TxtSearch.Size = new Size(332, 32);
            TxtSearch.TabIndex = 4;
            // 
            // LblUsers
            // 
            LblUsers.AutoSize = true;
            LblUsers.Font = new Font("Cambria", 24F, FontStyle.Bold);
            LblUsers.ForeColor = Color.White;
            LblUsers.Location = new Point(12, 18);
            LblUsers.Name = "LblUsers";
            LblUsers.Size = new Size(148, 37);
            LblUsers.TabIndex = 2;
            LblUsers.Text = "Usuarios";
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
            ToolBoxUsers.Items.AddRange(new ToolStripItem[] { BtnEdit, toolStripSeparator1, BtnDelete, toolStripSeparator2, BtnPrint });
            ToolBoxUsers.Location = new Point(0, 0);
            ToolBoxUsers.Name = "ToolBoxUsers";
            ToolBoxUsers.Size = new Size(931, 42);
            ToolBoxUsers.TabIndex = 0;
            ToolBoxUsers.Text = "toolStrip1";
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
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(statusStrip1);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 596);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(931, 34);
            BottomPanel.TabIndex = 5;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(40, 68, 131);
            statusStrip1.Dock = DockStyle.Fill;
            statusStrip1.Items.AddRange(new ToolStripItem[] { BtnMessage, LblMessage });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(931, 34);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
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
            BtnMessage.Size = new Size(29, 32);
            BtnMessage.Text = "Listo";
            // 
            // MessageReady
            // 
            MessageReady.BackColor = Color.White;
            MessageReady.ForeColor = Color.Black;
            MessageReady.Name = "MessageReady";
            MessageReady.Size = new Size(131, 22);
            MessageReady.Text = "¡Todo listo!";
            // 
            // LblMessage
            // 
            LblMessage.ForeColor = Color.White;
            LblMessage.Name = "LblMessage";
            LblMessage.Size = new Size(32, 29);
            LblMessage.Text = "Listo";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(dtgUsers);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 112);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(2);
            MainPanel.Size = new Size(931, 484);
            MainPanel.TabIndex = 6;
            // 
            // dtgUsers
            // 
            dtgUsers.AllowUserToAddRows = false;
            dtgUsers.AllowUserToDeleteRows = false;
            dtgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsers.BackgroundColor = Color.White;
            dtgUsers.BorderStyle = BorderStyle.None;
            dtgUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsers.Columns.AddRange(new DataGridViewColumn[] { Cell_ID, Cell_Name, Cell_Adress, Cell_PhoneNumber, Cell_Email, Cell_DNI });
            dtgUsers.Dock = DockStyle.Fill;
            dtgUsers.Location = new Point(2, 2);
            dtgUsers.Name = "dtgUsers";
            dtgUsers.ReadOnly = true;
            dtgUsers.RowHeadersVisible = false;
            dtgUsers.Size = new Size(927, 480);
            dtgUsers.TabIndex = 3;
            // 
            // Cell_ID
            // 
            Cell_ID.HeaderText = "ID";
            Cell_ID.Name = "Cell_ID";
            Cell_ID.ReadOnly = true;
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
            // Cell_DNI
            // 
            Cell_DNI.HeaderText = "Cedula de Identidad";
            Cell_DNI.Name = "Cell_DNI";
            Cell_DNI.ReadOnly = true;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(931, 630);
            Controls.Add(MainPanel);
            Controls.Add(BottomPanel);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            Name = "Users";
            Text = "Users";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ToolBoxUsers.ResumeLayout(false);
            ToolBoxUsers.PerformLayout();
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private TextBox TxtSearch;
        private Label LblUsers;
        private Panel UsernamePanel;
        private Panel SearchPanel;
        private Panel panel1;
        private ToolStrip ToolBoxUsers;
        private ToolStripButton BtnEdit;
        private Panel BottomPanel;
        private StatusStrip statusStrip1;
        private FontAwesome.Sharp.IconDropDownButton BtnMessage;
        private ToolStripStatusLabel LblMessage;
        private Panel MainPanel;
        private DataGridView dtgUsers;
        private DataGridViewTextBoxColumn Cell_ID;
        private DataGridViewTextBoxColumn Cell_Name;
        private DataGridViewTextBoxColumn Cell_Adress;
        private DataGridViewTextBoxColumn Cell_PhoneNumber;
        private DataGridViewTextBoxColumn Cell_Email;
        private DataGridViewTextBoxColumn Cell_DNI;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnPrint;
        private ToolStripMenuItem MessageReady;
        private PictureBox pictureBox1;
    }
}
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolutionForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            StatusStripBooks = new StatusStrip();
            BtnMessage = new FontAwesome.Sharp.IconDropDownButton();
            MessageReady = new ToolStripMenuItem();
            LblMessage = new ToolStripStatusLabel();
            panel2 = new Panel();
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
            SearchPanel = new Panel();
            pictureBox1 = new PictureBox();
            TxtSearch = new TextBox();
            UsernamePanel = new Panel();
            LblUsers = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            panel6 = new Panel();
            label1 = new Label();
            panel7 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            panel8 = new Panel();
            panel9 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            StatusStripBooks.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).BeginInit();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1064, 840);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(TopPanel);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1056, 807);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Devoluciones";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(StatusStripBooks);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 761);
            panel3.Name = "panel3";
            panel3.Size = new Size(1050, 42);
            panel3.TabIndex = 11;
            // 
            // StatusStripBooks
            // 
            StatusStripBooks.BackColor = Color.FromArgb(40, 68, 131);
            StatusStripBooks.Dock = DockStyle.Fill;
            StatusStripBooks.ImageScalingSize = new Size(20, 20);
            StatusStripBooks.Items.AddRange(new ToolStripItem[] { BtnMessage, LblMessage });
            StatusStripBooks.Location = new Point(0, 0);
            StatusStripBooks.Name = "StatusStripBooks";
            StatusStripBooks.Padding = new Padding(1, 0, 16, 0);
            StatusStripBooks.Size = new Size(1050, 42);
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
            BtnMessage.Size = new Size(34, 40);
            BtnMessage.Text = "Listo";
            // 
            // MessageReady
            // 
            MessageReady.BackColor = Color.White;
            MessageReady.ForeColor = Color.Black;
            MessageReady.Name = "MessageReady";
            MessageReady.Size = new Size(166, 26);
            MessageReady.Text = "¡Todo listo!";
            // 
            // LblMessage
            // 
            LblMessage.ForeColor = Color.White;
            LblMessage.Name = "LblMessage";
            LblMessage.Size = new Size(40, 36);
            LblMessage.Text = "Listo";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgBooks);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 603);
            panel2.TabIndex = 10;
            // 
            // dtgBooks
            // 
            dtgBooks.AllowUserToAddRows = false;
            dtgBooks.AllowUserToDeleteRows = false;
            dtgBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBooks.BackgroundColor = Color.White;
            dtgBooks.BorderStyle = BorderStyle.None;
            dtgBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBooks.Columns.AddRange(new DataGridViewColumn[] { Cell_ID, Cell_Title, Cell_Autor, Cell_ISBN, Categorie, Cell_Editorial, Cell_Year, Cell_Quantity, Cell_State });
            dtgBooks.Dock = DockStyle.Fill;
            dtgBooks.Location = new Point(0, 0);
            dtgBooks.Margin = new Padding(3, 4, 3, 4);
            dtgBooks.Name = "dtgBooks";
            dtgBooks.ReadOnly = true;
            dtgBooks.RowHeadersVisible = false;
            dtgBooks.RowHeadersWidth = 51;
            dtgBooks.Size = new Size(1050, 603);
            dtgBooks.TabIndex = 4;
            // 
            // Cell_ID
            // 
            Cell_ID.HeaderText = "ID";
            Cell_ID.MinimumWidth = 6;
            Cell_ID.Name = "Cell_ID";
            Cell_ID.ReadOnly = true;
            // 
            // Cell_Title
            // 
            Cell_Title.HeaderText = "Titulo";
            Cell_Title.MinimumWidth = 6;
            Cell_Title.Name = "Cell_Title";
            Cell_Title.ReadOnly = true;
            // 
            // Cell_Autor
            // 
            Cell_Autor.HeaderText = "Autor";
            Cell_Autor.MinimumWidth = 6;
            Cell_Autor.Name = "Cell_Autor";
            Cell_Autor.ReadOnly = true;
            // 
            // Cell_ISBN
            // 
            Cell_ISBN.HeaderText = "ISBN";
            Cell_ISBN.MinimumWidth = 6;
            Cell_ISBN.Name = "Cell_ISBN";
            Cell_ISBN.ReadOnly = true;
            // 
            // Categorie
            // 
            Categorie.HeaderText = "Categorias";
            Categorie.MinimumWidth = 6;
            Categorie.Name = "Categorie";
            Categorie.ReadOnly = true;
            // 
            // Cell_Editorial
            // 
            Cell_Editorial.HeaderText = "Editorial";
            Cell_Editorial.MinimumWidth = 6;
            Cell_Editorial.Name = "Cell_Editorial";
            Cell_Editorial.ReadOnly = true;
            // 
            // Cell_Year
            // 
            Cell_Year.HeaderText = "Año de publicacion";
            Cell_Year.MinimumWidth = 6;
            Cell_Year.Name = "Cell_Year";
            Cell_Year.ReadOnly = true;
            // 
            // Cell_Quantity
            // 
            Cell_Quantity.HeaderText = "Stock";
            Cell_Quantity.MinimumWidth = 6;
            Cell_Quantity.Name = "Cell_Quantity";
            Cell_Quantity.ReadOnly = true;
            // 
            // Cell_State
            // 
            Cell_State.HeaderText = "Estado";
            Cell_State.MinimumWidth = 6;
            Cell_State.Name = "Cell_State";
            Cell_State.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ToolBoxUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 97);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 61);
            panel1.TabIndex = 9;
            // 
            // ToolBoxUsers
            // 
            ToolBoxUsers.Dock = DockStyle.Fill;
            ToolBoxUsers.ImageScalingSize = new Size(20, 20);
            ToolBoxUsers.Items.AddRange(new ToolStripItem[] { BtnAddBook, toolStripSeparator3, BtnEdit, toolStripSeparator1, BtnDelete, toolStripSeparator2, BtnPrint });
            ToolBoxUsers.Location = new Point(0, 0);
            ToolBoxUsers.Name = "ToolBoxUsers";
            ToolBoxUsers.Size = new Size(1050, 61);
            ToolBoxUsers.TabIndex = 1;
            ToolBoxUsers.Text = "toolStrip1";
            // 
            // BtnAddBook
            // 
            BtnAddBook.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnAddBook.Image = (Image)resources.GetObject("BtnAddBook.Image");
            BtnAddBook.ImageTransparentColor = Color.Magenta;
            BtnAddBook.Name = "BtnAddBook";
            BtnAddBook.Size = new Size(104, 58);
            BtnAddBook.Text = "Agregar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 61);
            // 
            // BtnEdit
            // 
            BtnEdit.Enabled = false;
            BtnEdit.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.ImageTransparentColor = Color.Magenta;
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(88, 58);
            BtnEdit.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 61);
            // 
            // BtnDelete
            // 
            BtnDelete.Enabled = false;
            BtnDelete.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.ImageTransparentColor = Color.Magenta;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(110, 58);
            BtnDelete.Text = "Eliminar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 61);
            // 
            // BtnPrint
            // 
            BtnPrint.Font = new Font("Cambria", 11F, FontStyle.Bold);
            BtnPrint.Image = (Image)resources.GetObject("BtnPrint.Image");
            BtnPrint.ImageTransparentColor = Color.Magenta;
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(116, 58);
            BtnPrint.Text = "Imprimir";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(40, 68, 131);
            TopPanel.Controls.Add(SearchPanel);
            TopPanel.Controls.Add(LblUsers);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(3, 4);
            TopPanel.Margin = new Padding(3, 4, 3, 4);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1050, 93);
            TopPanel.TabIndex = 8;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(pictureBox1);
            SearchPanel.Controls.Add(TxtSearch);
            SearchPanel.Controls.Add(UsernamePanel);
            SearchPanel.Dock = DockStyle.Right;
            SearchPanel.Location = new Point(529, 0);
            SearchPanel.Margin = new Padding(3, 4, 3, 4);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(521, 93);
            SearchPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(66, 23);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 47);
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
            TxtSearch.Location = new Point(128, 24);
            TxtSearch.Margin = new Padding(3, 4, 3, 4);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Buscar Devoluciones....";
            TxtSearch.Size = new Size(379, 40);
            TxtSearch.TabIndex = 11;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.White;
            UsernamePanel.Location = new Point(127, 67);
            UsernamePanel.Margin = new Padding(3, 4, 3, 4);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(379, 1);
            UsernamePanel.TabIndex = 12;
            // 
            // LblUsers
            // 
            LblUsers.AutoSize = true;
            LblUsers.Font = new Font("Cambria", 24F, FontStyle.Bold);
            LblUsers.ForeColor = Color.White;
            LblUsers.Location = new Point(14, 24);
            LblUsers.Name = "LblUsers";
            LblUsers.Size = new Size(265, 47);
            LblUsers.TabIndex = 2;
            LblUsers.Text = "Devoluciones";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel9);
            tabPage2.Controls.Add(panel8);
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1056, 807);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Prestamos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 68, 131);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 4);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1050, 93);
            panel4.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(529, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(521, 93);
            panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(66, 23);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 47);
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
            textBox1.Location = new Point(128, 24);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar Prestamos....";
            textBox1.Size = new Size(379, 40);
            textBox1.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(127, 67);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(379, 1);
            panel6.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(214, 47);
            label1.TabIndex = 2;
            label1.Text = "Prestamos";
            // 
            // panel7
            // 
            panel7.Controls.Add(toolStrip1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 97);
            panel7.Name = "panel7";
            panel7.Size = new Size(1050, 67);
            panel7.TabIndex = 10;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator4, toolStripButton2, toolStripSeparator5, toolStripButton3, toolStripSeparator6, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1050, 67);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(104, 64);
            toolStripButton1.Text = "Agregar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 67);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Enabled = false;
            toolStripButton2.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(88, 64);
            toolStripButton2.Text = "Editar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 67);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Enabled = false;
            toolStripButton3.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(110, 64);
            toolStripButton3.Text = "Eliminar";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 67);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Font = new Font("Cambria", 11F, FontStyle.Bold);
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(116, 64);
            toolStripButton4.Text = "Imprimir";
            // 
            // panel8
            // 
            panel8.Controls.Add(dataGridView1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(3, 164);
            panel8.Name = "panel8";
            panel8.Size = new Size(1050, 564);
            panel8.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.Controls.Add(statusStrip1);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 728);
            panel9.Name = "panel9";
            panel9.Size = new Size(1050, 75);
            panel9.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 564);
            dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Autor";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "ISBN";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Categorias";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Editorial";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Año de publicacion";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Stock";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Estado";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(40, 68, 131);
            statusStrip1.Dock = DockStyle.Fill;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { iconDropDownButton1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1050, 75);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.Message;
            iconDropDownButton1.IconColor = Color.White;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconDropDownButton1.ImageTransparentColor = Color.Magenta;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(34, 73);
            iconDropDownButton1.Text = "Listo";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.White;
            toolStripMenuItem1.ForeColor = Color.Black;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(166, 26);
            toolStripMenuItem1.Text = "¡Todo listo!";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(40, 69);
            toolStripStatusLabel1.Text = "Listo";
            // 
            // DevolutionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 840);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DevolutionForm";
            Text = "DevolutionForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            StatusStripBooks.ResumeLayout(false);
            StatusStripBooks.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgBooks).EndInit();
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStrip ToolBoxUsers;
        private ToolStripButton BtnAddBook;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BtnEdit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnPrint;
        private Panel panel3;
        private Panel panel2;
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
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Panel panel6;
        private Label label1;
        private Panel panel9;
        private Panel panel8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Panel panel7;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton4;
        private StatusStrip statusStrip1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
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
            BottomPanel = new Panel();
            StatusStripBooks = new StatusStrip();
            BtnMessage = new FontAwesome.Sharp.IconDropDownButton();
            MessageReady = new ToolStripMenuItem();
            LblMessage = new ToolStripStatusLabel();
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
            FlpBooks = new FlowLayoutPanel();
            BottomPanel.SuspendLayout();
            StatusStripBooks.SuspendLayout();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            TopPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(StatusStripBooks);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 596);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(931, 34);
            BottomPanel.TabIndex = 9;
            // 
            // StatusStripBooks
            // 
            StatusStripBooks.BackColor = Color.FromArgb(40, 68, 131);
            StatusStripBooks.Dock = DockStyle.Fill;
            StatusStripBooks.Items.AddRange(new ToolStripItem[] { BtnMessage, LblMessage });
            StatusStripBooks.Location = new Point(0, 0);
            StatusStripBooks.Name = "StatusStripBooks";
            StatusStripBooks.Size = new Size(931, 34);
            StatusStripBooks.TabIndex = 4;
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
            BtnMessage.Size = new Size(29, 32);
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
            LblMessage.Size = new Size(32, 29);
            LblMessage.Text = "Listo";
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
            // FlpBooks
            // 
            FlpBooks.Dock = DockStyle.Fill;
            FlpBooks.Location = new Point(0, 112);
            FlpBooks.Name = "FlpBooks";
            FlpBooks.Size = new Size(931, 484);
            FlpBooks.TabIndex = 10;
            // 
            // MainFormBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 630);
            Controls.Add(FlpBooks);
            Controls.Add(BottomPanel);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            Name = "MainFormBooks";
            Text = "Books";
            Load += MainFormBooks_Load;
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
            StatusStripBooks.ResumeLayout(false);
            StatusStripBooks.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ToolBoxUsers.ResumeLayout(false);
            ToolBoxUsers.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel BottomPanel;
        private StatusStrip StatusStripBooks;
        private FontAwesome.Sharp.IconDropDownButton BtnMessage;
        private ToolStripMenuItem MessageReady;
        private ToolStripStatusLabel LblMessage;
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
        private FlowLayoutPanel FlpBooks;
    }
}
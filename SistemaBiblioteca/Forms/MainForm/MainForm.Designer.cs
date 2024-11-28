namespace SistemaBiblioteca
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            LateralPanel = new Panel();
            BtnReports = new FontAwesome.Sharp.IconButton();
            BtnBooks = new FontAwesome.Sharp.IconButton();
            BtnUsers = new FontAwesome.Sharp.IconButton();
            BtnDevolutions = new FontAwesome.Sharp.IconButton();
            IconPanel = new Panel();
            LogoPicture = new PictureBox();
            MainPanel = new Panel();
            LateralPanel.SuspendLayout();
            IconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            SuspendLayout();
            // 
            // LateralPanel
            // 
            LateralPanel.BackColor = Color.White;
            LateralPanel.BorderStyle = BorderStyle.FixedSingle;
            LateralPanel.Controls.Add(BtnReports);
            LateralPanel.Controls.Add(BtnBooks);
            LateralPanel.Controls.Add(BtnUsers);
            LateralPanel.Controls.Add(BtnDevolutions);
            LateralPanel.Controls.Add(IconPanel);
            LateralPanel.Dock = DockStyle.Left;
            LateralPanel.Location = new Point(0, 0);
            LateralPanel.Name = "LateralPanel";
            LateralPanel.Size = new Size(358, 630);
            LateralPanel.TabIndex = 0;
            // 
            // BtnReports
            // 
            BtnReports.BackColor = Color.White;
            BtnReports.Cursor = Cursors.Hand;
            BtnReports.Dock = DockStyle.Top;
            BtnReports.FlatAppearance.BorderSize = 0;
            BtnReports.FlatStyle = FlatStyle.Popup;
            BtnReports.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReports.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            BtnReports.IconColor = Color.Black;
            BtnReports.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnReports.IconSize = 60;
            BtnReports.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReports.Location = new Point(0, 470);
            BtnReports.Name = "BtnReports";
            BtnReports.Size = new Size(356, 73);
            BtnReports.TabIndex = 4;
            BtnReports.Text = "Reportes";
            BtnReports.UseVisualStyleBackColor = false;
            // 
            // BtnBooks
            // 
            BtnBooks.BackColor = Color.White;
            BtnBooks.Cursor = Cursors.Hand;
            BtnBooks.Dock = DockStyle.Top;
            BtnBooks.FlatAppearance.BorderSize = 0;
            BtnBooks.FlatStyle = FlatStyle.Popup;
            BtnBooks.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnBooks.IconColor = Color.Black;
            BtnBooks.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnBooks.IconSize = 60;
            BtnBooks.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBooks.Location = new Point(0, 397);
            BtnBooks.Name = "BtnBooks";
            BtnBooks.Size = new Size(356, 73);
            BtnBooks.TabIndex = 1;
            BtnBooks.Text = "Libros";
            BtnBooks.UseVisualStyleBackColor = false;
            BtnBooks.Click += ShowBooks;
            // 
            // BtnUsers
            // 
            BtnUsers.BackColor = Color.White;
            BtnUsers.Cursor = Cursors.Hand;
            BtnUsers.Dock = DockStyle.Top;
            BtnUsers.FlatAppearance.BorderSize = 0;
            BtnUsers.FlatStyle = FlatStyle.Popup;
            BtnUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUsers.IconChar = FontAwesome.Sharp.IconChar.User;
            BtnUsers.IconColor = Color.Black;
            BtnUsers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnUsers.IconSize = 60;
            BtnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUsers.Location = new Point(0, 324);
            BtnUsers.Name = "BtnUsers";
            BtnUsers.Size = new Size(356, 73);
            BtnUsers.TabIndex = 2;
            BtnUsers.Text = "Estudiantes";
            BtnUsers.UseVisualStyleBackColor = false;
            BtnUsers.Click += ShowUsers;
            // 
            // BtnDevolutions
            // 
            BtnDevolutions.BackColor = Color.White;
            BtnDevolutions.Cursor = Cursors.Hand;
            BtnDevolutions.Dock = DockStyle.Top;
            BtnDevolutions.FlatAppearance.BorderSize = 0;
            BtnDevolutions.FlatStyle = FlatStyle.Popup;
            BtnDevolutions.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDevolutions.IconChar = FontAwesome.Sharp.IconChar.HandsHolding;
            BtnDevolutions.IconColor = Color.Black;
            BtnDevolutions.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnDevolutions.IconSize = 60;
            BtnDevolutions.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDevolutions.Location = new Point(0, 251);
            BtnDevolutions.Name = "BtnDevolutions";
            BtnDevolutions.Size = new Size(356, 73);
            BtnDevolutions.TabIndex = 3;
            BtnDevolutions.Text = "Prestamos y Devoluciones";
            BtnDevolutions.TextAlign = ContentAlignment.MiddleRight;
            BtnDevolutions.UseVisualStyleBackColor = false;
            BtnDevolutions.Click += ShowDevolutions;
            // 
            // IconPanel
            // 
            IconPanel.Controls.Add(LogoPicture);
            IconPanel.Dock = DockStyle.Top;
            IconPanel.Location = new Point(0, 0);
            IconPanel.Name = "IconPanel";
            IconPanel.Size = new Size(356, 251);
            IconPanel.TabIndex = 0;
            // 
            // LogoPicture
            // 
            LogoPicture.Dock = DockStyle.Fill;
            LogoPicture.Image = Properties.Resources.PuertasAMilMundosLogo;
            LogoPicture.Location = new Point(0, 0);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(356, 251);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(358, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(931, 630);
            MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1289, 630);
            Controls.Add(MainPanel);
            Controls.Add(LateralPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += Exit;
            Load += MainForm_Load;
            LateralPanel.ResumeLayout(false);
            IconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LateralPanel;
        private Panel MainPanel;
        private Panel IconPanel;
        private PictureBox LogoPicture;
        private FontAwesome.Sharp.IconButton BtnBooks;
        private FontAwesome.Sharp.IconButton BtnDevolutions;
        private FontAwesome.Sharp.IconButton BtnUsers;
        private FontAwesome.Sharp.IconButton BtnReports;
    }
}

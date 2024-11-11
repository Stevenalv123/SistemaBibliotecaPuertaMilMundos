namespace SistemaBiblioteca.Forms
{
    partial class Login
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
            IconPanel = new Panel();
            PicLogo = new PictureBox();
            LblWelcome = new Label();
            MainPanel = new Panel();
            LblErrorPassword = new Label();
            LblErrorUserName = new Label();
            PasswordPanel = new Panel();
            UsernamePanel = new Panel();
            BtnHelp = new FontAwesome.Sharp.IconButton();
            BtnCancel = new Button();
            BtnAccept = new Button();
            PicPassword = new FontAwesome.Sharp.IconPictureBox();
            PicUsername = new FontAwesome.Sharp.IconPictureBox();
            TxtUserName = new TextBox();
            TxtPassword = new TextBox();
            IconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicUsername).BeginInit();
            SuspendLayout();
            // 
            // IconPanel
            // 
            IconPanel.Controls.Add(PicLogo);
            IconPanel.Dock = DockStyle.Top;
            IconPanel.Location = new Point(0, 0);
            IconPanel.Name = "IconPanel";
            IconPanel.Size = new Size(455, 161);
            IconPanel.TabIndex = 0;
            // 
            // PicLogo
            // 
            PicLogo.BackColor = Color.White;
            PicLogo.Dock = DockStyle.Fill;
            PicLogo.Image = Properties.Resources.PuertasAMilMundosLogo;
            PicLogo.Location = new Point(0, 0);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(455, 161);
            PicLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PicLogo.TabIndex = 0;
            PicLogo.TabStop = false;
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Font = new Font("Cambria", 24F, FontStyle.Bold);
            LblWelcome.Location = new Point(66, 3);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(323, 37);
            LblWelcome.TabIndex = 1;
            LblWelcome.Text = "Bienvenido de Nuevo";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(LblErrorPassword);
            MainPanel.Controls.Add(LblErrorUserName);
            MainPanel.Controls.Add(PasswordPanel);
            MainPanel.Controls.Add(UsernamePanel);
            MainPanel.Controls.Add(BtnHelp);
            MainPanel.Controls.Add(BtnCancel);
            MainPanel.Controls.Add(BtnAccept);
            MainPanel.Controls.Add(PicPassword);
            MainPanel.Controls.Add(PicUsername);
            MainPanel.Controls.Add(TxtUserName);
            MainPanel.Controls.Add(TxtPassword);
            MainPanel.Controls.Add(LblWelcome);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 161);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(455, 291);
            MainPanel.TabIndex = 1;
            // 
            // LblErrorPassword
            // 
            LblErrorPassword.AutoSize = true;
            LblErrorPassword.ForeColor = Color.Red;
            LblErrorPassword.Location = new Point(70, 173);
            LblErrorPassword.Name = "LblErrorPassword";
            LblErrorPassword.Size = new Size(39, 14);
            LblErrorPassword.TabIndex = 10;
            LblErrorPassword.Text = "label2";
            LblErrorPassword.Visible = false;
            // 
            // LblErrorUserName
            // 
            LblErrorUserName.AutoSize = true;
            LblErrorUserName.ForeColor = Color.Red;
            LblErrorUserName.Location = new Point(66, 91);
            LblErrorUserName.Name = "LblErrorUserName";
            LblErrorUserName.Size = new Size(39, 14);
            LblErrorUserName.TabIndex = 9;
            LblErrorUserName.Text = "label2";
            LblErrorUserName.Visible = false;
            // 
            // PasswordPanel
            // 
            PasswordPanel.BackColor = Color.Black;
            PasswordPanel.Location = new Point(70, 169);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Size = new Size(377, 1);
            PasswordPanel.TabIndex = 8;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.Black;
            UsernamePanel.Location = new Point(68, 87);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(377, 1);
            UsernamePanel.TabIndex = 7;
            // 
            // BtnHelp
            // 
            BtnHelp.Cursor = Cursors.Hand;
            BtnHelp.FlatAppearance.BorderSize = 0;
            BtnHelp.FlatStyle = FlatStyle.Flat;
            BtnHelp.Font = new Font("Cambria", 14F, FontStyle.Bold);
            BtnHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            BtnHelp.IconColor = Color.Black;
            BtnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnHelp.IconSize = 36;
            BtnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHelp.Location = new Point(12, 227);
            BtnHelp.Name = "BtnHelp";
            BtnHelp.Size = new Size(99, 40);
            BtnHelp.TabIndex = 6;
            BtnHelp.Text = "Help";
            BtnHelp.TextAlign = ContentAlignment.MiddleRight;
            BtnHelp.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(171, 227);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnAccept
            // 
            BtnAccept.BackColor = Color.FromArgb(40, 68, 131);
            BtnAccept.Cursor = Cursors.Hand;
            BtnAccept.FlatAppearance.BorderSize = 0;
            BtnAccept.FlatStyle = FlatStyle.Flat;
            BtnAccept.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnAccept.ForeColor = Color.White;
            BtnAccept.Location = new Point(310, 227);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(133, 40);
            BtnAccept.TabIndex = 4;
            BtnAccept.Text = "Aceptar";
            BtnAccept.UseVisualStyleBackColor = false;
            BtnAccept.Click += BtnAccept_Click;
            // 
            // PicPassword
            // 
            PicPassword.BackColor = Color.White;
            PicPassword.ForeColor = SystemColors.ControlText;
            PicPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            PicPassword.IconColor = SystemColors.ControlText;
            PicPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PicPassword.IconSize = 50;
            PicPassword.Location = new Point(14, 127);
            PicPassword.Name = "PicPassword";
            PicPassword.Size = new Size(50, 50);
            PicPassword.TabIndex = 4;
            PicPassword.TabStop = false;
            // 
            // PicUsername
            // 
            PicUsername.BackColor = Color.White;
            PicUsername.ForeColor = SystemColors.ControlText;
            PicUsername.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            PicUsername.IconColor = SystemColors.ControlText;
            PicUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PicUsername.IconSize = 50;
            PicUsername.Location = new Point(12, 45);
            PicUsername.Name = "PicUsername";
            PicUsername.Size = new Size(50, 50);
            PicUsername.TabIndex = 4;
            PicUsername.TabStop = false;
            // 
            // TxtUserName
            // 
            TxtUserName.BorderStyle = BorderStyle.None;
            TxtUserName.Cursor = Cursors.IBeam;
            TxtUserName.Font = new Font("Cambria", 18F);
            TxtUserName.HideSelection = false;
            TxtUserName.Location = new Point(66, 52);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.PlaceholderText = "Nombre de Usuario";
            TxtUserName.Size = new Size(377, 29);
            TxtUserName.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Cursor = Cursors.IBeam;
            TxtPassword.Font = new Font("Cambria", 18F);
            TxtPassword.HideSelection = false;
            TxtPassword.Location = new Point(68, 134);
            TxtPassword.MaxLength = 12;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '•';
            TxtPassword.PlaceholderText = "Contraseña";
            TxtPassword.Size = new Size(377, 29);
            TxtPassword.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 452);
            Controls.Add(MainPanel);
            Controls.Add(IconPanel);
            Font = new Font("Cambria", 9F);
            MaximizeBox = false;
            MaximumSize = new Size(471, 491);
            MinimizeBox = false;
            MinimumSize = new Size(471, 491);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            TopMost = true;
            IconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicUsername).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel IconPanel;
        private PictureBox PicLogo;
        private Label LblWelcome;
        private Panel MainPanel;
        private FontAwesome.Sharp.IconPictureBox PicUsername;
        private TextBox TxtUserName;
        private FontAwesome.Sharp.IconPictureBox PicPassword;
        private TextBox TxtPassword;
        private Button BtnCancel;
        private Button BtnAccept;
        private FontAwesome.Sharp.IconButton BtnHelp;
        private Panel UsernamePanel;
        private Panel PasswordPanel;
        private Label LblErrorUserName;
        private Label LblErrorPassword;
    }
}
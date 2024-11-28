namespace SistemaBiblioteca.Forms.AdminsForms
{
    partial class Register
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
            UsernamePanel = new Panel();
            TxtUserName = new TextBox();
            MainPanel = new Panel();
            LblErrorPassword = new Label();
            LblErrorUserName = new Label();
            panel1 = new Panel();
            PasswordPanel = new Panel();
            BtnCancel = new Button();
            BtnAccept = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            PicPassword = new FontAwesome.Sharp.IconPictureBox();
            PicUsername = new FontAwesome.Sharp.IconPictureBox();
            TxtConfirmPassword = new TextBox();
            TxtPassword = new TextBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicUsername).BeginInit();
            SuspendLayout();
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.Black;
            UsernamePanel.Location = new Point(74, 69);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(377, 1);
            UsernamePanel.TabIndex = 7;
            // 
            // TxtUserName
            // 
            TxtUserName.BorderStyle = BorderStyle.None;
            TxtUserName.Cursor = Cursors.IBeam;
            TxtUserName.Font = new Font("Cambria", 18F);
            TxtUserName.HideSelection = false;
            TxtUserName.Location = new Point(72, 34);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.PlaceholderText = "Nombre de Usuario";
            TxtUserName.Size = new Size(377, 29);
            TxtUserName.TabIndex = 3;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(LblErrorPassword);
            MainPanel.Controls.Add(LblErrorUserName);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(PasswordPanel);
            MainPanel.Controls.Add(UsernamePanel);
            MainPanel.Controls.Add(BtnCancel);
            MainPanel.Controls.Add(BtnAccept);
            MainPanel.Controls.Add(iconPictureBox1);
            MainPanel.Controls.Add(PicPassword);
            MainPanel.Controls.Add(PicUsername);
            MainPanel.Controls.Add(TxtUserName);
            MainPanel.Controls.Add(TxtConfirmPassword);
            MainPanel.Controls.Add(TxtPassword);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(461, 333);
            MainPanel.TabIndex = 2;
            // 
            // LblErrorPassword
            // 
            LblErrorPassword.AutoSize = true;
            LblErrorPassword.ForeColor = Color.Red;
            LblErrorPassword.Location = new Point(78, 221);
            LblErrorPassword.Name = "LblErrorPassword";
            LblErrorPassword.Size = new Size(38, 15);
            LblErrorPassword.TabIndex = 10;
            LblErrorPassword.Text = "label2";
            LblErrorPassword.Visible = false;
            // 
            // LblErrorUserName
            // 
            LblErrorUserName.AutoSize = true;
            LblErrorUserName.ForeColor = Color.Red;
            LblErrorUserName.Location = new Point(72, 73);
            LblErrorUserName.Name = "LblErrorUserName";
            LblErrorUserName.Size = new Size(38, 15);
            LblErrorUserName.TabIndex = 9;
            LblErrorUserName.Text = "label2";
            LblErrorUserName.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(78, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 1);
            panel1.TabIndex = 8;
            // 
            // PasswordPanel
            // 
            PasswordPanel.BackColor = Color.Black;
            PasswordPanel.Location = new Point(76, 151);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Size = new Size(377, 1);
            PasswordPanel.TabIndex = 8;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(12, 281);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnAccept
            // 
            BtnAccept.BackColor = Color.FromArgb(40, 68, 131);
            BtnAccept.Cursor = Cursors.Hand;
            BtnAccept.FlatAppearance.BorderSize = 0;
            BtnAccept.FlatStyle = FlatStyle.Flat;
            BtnAccept.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnAccept.ForeColor = Color.White;
            BtnAccept.Location = new Point(316, 281);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(133, 40);
            BtnAccept.TabIndex = 4;
            BtnAccept.Text = "Aceptar";
            BtnAccept.UseVisualStyleBackColor = false;
            BtnAccept.Click += BtnAccept_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(22, 175);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(50, 50);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // PicPassword
            // 
            PicPassword.BackColor = Color.White;
            PicPassword.ForeColor = SystemColors.ControlText;
            PicPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            PicPassword.IconColor = SystemColors.ControlText;
            PicPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PicPassword.IconSize = 50;
            PicPassword.Location = new Point(20, 109);
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
            PicUsername.Location = new Point(18, 27);
            PicUsername.Name = "PicUsername";
            PicUsername.Size = new Size(50, 50);
            PicUsername.TabIndex = 4;
            PicUsername.TabStop = false;
            // 
            // TxtConfirmPassword
            // 
            TxtConfirmPassword.BorderStyle = BorderStyle.None;
            TxtConfirmPassword.Cursor = Cursors.IBeam;
            TxtConfirmPassword.Font = new Font("Cambria", 18F);
            TxtConfirmPassword.HideSelection = false;
            TxtConfirmPassword.Location = new Point(76, 182);
            TxtConfirmPassword.MaxLength = 12;
            TxtConfirmPassword.Name = "TxtConfirmPassword";
            TxtConfirmPassword.PasswordChar = '•';
            TxtConfirmPassword.PlaceholderText = "Contraseña";
            TxtConfirmPassword.Size = new Size(377, 29);
            TxtConfirmPassword.TabIndex = 3;
            // 
            // TxtPassword
            // 
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Cursor = Cursors.IBeam;
            TxtPassword.Font = new Font("Cambria", 18F);
            TxtPassword.HideSelection = false;
            TxtPassword.Location = new Point(74, 116);
            TxtPassword.MaxLength = 12;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '•';
            TxtPassword.PlaceholderText = "Contraseña";
            TxtPassword.Size = new Size(377, 29);
            TxtPassword.TabIndex = 3;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 333);
            Controls.Add(MainPanel);
            MaximizeBox = false;
            MaximumSize = new Size(477, 372);
            MinimizeBox = false;
            MinimumSize = new Size(477, 372);
            Name = "Register";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicUsername).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel UsernamePanel;
        private TextBox TxtUserName;
        private Panel MainPanel;
        private Panel PasswordPanel;
        private Button BtnCancel;
        private Button BtnAccept;
        private FontAwesome.Sharp.IconPictureBox PicPassword;
        private FontAwesome.Sharp.IconPictureBox PicUsername;
        private TextBox TxtPassword;
        private Label LblErrorPassword;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox TxtConfirmPassword;
        private Label LblErrorUserName;
    }
}
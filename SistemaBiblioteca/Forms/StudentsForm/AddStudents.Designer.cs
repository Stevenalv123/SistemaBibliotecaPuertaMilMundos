namespace SistemaBiblioteca.Forms.StudentsForm
{
    partial class AddStudents
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
            TxtEmail = new TextBox();
            label2 = new Label();
            BtnCancel = new Button();
            BtnAccept = new Button();
            TxtCarrer = new TextBox();
            label7 = new Label();
            MtbTelephone = new MaskedTextBox();
            label6 = new Label();
            TxtAdress = new TextBox();
            label5 = new Label();
            TxtName = new TextBox();
            label4 = new Label();
            MtbCarnet = new MaskedTextBox();
            label3 = new Label();
            panel1 = new Panel();
            BtnClose = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Font = new Font("Cambria", 14F);
            TxtEmail.Location = new Point(238, 253);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(233, 29);
            TxtEmail.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.Location = new Point(238, 229);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 28;
            label2.Text = "Email";
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
            BtnCancel.Location = new Point(158, 381);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 27;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnAccept
            // 
            BtnAccept.BackColor = Color.FromArgb(40, 68, 131);
            BtnAccept.Cursor = Cursors.Hand;
            BtnAccept.DialogResult = DialogResult.OK;
            BtnAccept.FlatAppearance.BorderSize = 0;
            BtnAccept.FlatStyle = FlatStyle.Flat;
            BtnAccept.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnAccept.ForeColor = Color.White;
            BtnAccept.Location = new Point(19, 381);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(133, 40);
            BtnAccept.TabIndex = 26;
            BtnAccept.Text = "Registrar";
            BtnAccept.UseVisualStyleBackColor = false;
            BtnAccept.Click += BtnAccept_Click;
            // 
            // TxtCarrer
            // 
            TxtCarrer.BorderStyle = BorderStyle.FixedSingle;
            TxtCarrer.Font = new Font("Cambria", 14F);
            TxtCarrer.Location = new Point(20, 323);
            TxtCarrer.Name = "TxtCarrer";
            TxtCarrer.Size = new Size(451, 29);
            TxtCarrer.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label7.Location = new Point(20, 299);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 24;
            label7.Text = "Carrera";
            // 
            // MtbTelephone
            // 
            MtbTelephone.BorderStyle = BorderStyle.FixedSingle;
            MtbTelephone.Font = new Font("Cambria", 14F);
            MtbTelephone.Location = new Point(20, 253);
            MtbTelephone.Mask = "0000-0000";
            MtbTelephone.Name = "MtbTelephone";
            MtbTelephone.PromptChar = ' ';
            MtbTelephone.Size = new Size(202, 29);
            MtbTelephone.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label6.Location = new Point(20, 231);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 22;
            label6.Text = "Telefono";
            // 
            // TxtAdress
            // 
            TxtAdress.BorderStyle = BorderStyle.FixedSingle;
            TxtAdress.Font = new Font("Cambria", 14F);
            TxtAdress.Location = new Point(20, 190);
            TxtAdress.Name = "TxtAdress";
            TxtAdress.Size = new Size(451, 29);
            TxtAdress.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label5.Location = new Point(20, 168);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 20;
            label5.Text = "Direccion";
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.FixedSingle;
            TxtName.Font = new Font("Cambria", 14F);
            TxtName.Location = new Point(158, 121);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(313, 29);
            TxtName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label4.Location = new Point(158, 99);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 18;
            label4.Text = "Nombre";
            // 
            // MtbCarnet
            // 
            MtbCarnet.BorderStyle = BorderStyle.FixedSingle;
            MtbCarnet.Font = new Font("Cambria", 14F);
            MtbCarnet.Location = new Point(20, 121);
            MtbCarnet.Mask = "0000-0000L";
            MtbCarnet.Name = "MtbCarnet";
            MtbCarnet.PromptChar = ' ';
            MtbCarnet.Size = new Size(132, 29);
            MtbCarnet.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.Location = new Point(20, 99);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 16;
            label3.Text = "Nª Carnet";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 68, 131);
            panel1.Controls.Add(BtnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 58);
            panel1.TabIndex = 15;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.Transparent;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Font = new Font("Arial", 14F, FontStyle.Bold);
            BtnClose.ForeColor = Color.White;
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnClose.IconColor = Color.Black;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.Location = new Point(410, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(61, 38);
            BtnClose.TabIndex = 1;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(160, 22);
            label1.TabIndex = 0;
            label1.Text = "Nuevo estudiante";
            // 
            // AddStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 450);
            Controls.Add(TxtEmail);
            Controls.Add(label2);
            Controls.Add(BtnCancel);
            Controls.Add(BtnAccept);
            Controls.Add(TxtCarrer);
            Controls.Add(label7);
            Controls.Add(MtbTelephone);
            Controls.Add(label6);
            Controls.Add(TxtAdress);
            Controls.Add(label5);
            Controls.Add(TxtName);
            Controls.Add(label4);
            Controls.Add(MtbCarnet);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudents";
            Load += AddStudents_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEmail;
        private Label label2;
        private Button BtnCancel;
        private Button BtnAccept;
        private TextBox TxtCarrer;
        private Label label7;
        private MaskedTextBox MtbTelephone;
        private Label label6;
        private TextBox TxtAdress;
        private Label label5;
        private TextBox TxtName;
        private Label label4;
        private MaskedTextBox MtbCarnet;
        private Label label3;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private Label label1;
    }
}
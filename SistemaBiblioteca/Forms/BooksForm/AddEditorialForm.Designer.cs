namespace SistemaBiblioteca.Forms.BooksForm
{
    partial class AddEditorialForm
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
            BtnCancel = new Button();
            BtnSave = new Button();
            MtbPhoneNumber = new MaskedTextBox();
            TxtAdress = new TextBox();
            TxtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            TxtEmail = new TextBox();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(500, 68);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(40, 68, 131);
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(500, 22);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(133, 40);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // MtbPhoneNumber
            // 
            MtbPhoneNumber.BackColor = Color.White;
            MtbPhoneNumber.BeepOnError = true;
            MtbPhoneNumber.Font = new Font("Cambria", 15.75F);
            MtbPhoneNumber.HidePromptOnLeave = true;
            MtbPhoneNumber.Location = new Point(192, 95);
            MtbPhoneNumber.Mask = "(999)0000-0000";
            MtbPhoneNumber.Name = "MtbPhoneNumber";
            MtbPhoneNumber.PromptChar = ' ';
            MtbPhoneNumber.RejectInputOnFirstFailure = true;
            MtbPhoneNumber.Size = new Size(279, 32);
            MtbPhoneNumber.SkipLiterals = false;
            MtbPhoneNumber.TabIndex = 3;
            // 
            // TxtAdress
            // 
            TxtAdress.Location = new Point(192, 57);
            TxtAdress.Name = "TxtAdress";
            TxtAdress.Size = new Size(279, 29);
            TxtAdress.TabIndex = 2;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(192, 19);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(279, 29);
            TxtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(176, 22);
            label3.TabIndex = 23;
            label3.Text = "Numero de telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 57);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 24;
            label2.Text = "Direccion: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 22);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 25;
            label1.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 136);
            label4.Name = "label4";
            label4.Size = new Size(164, 22);
            label4.TabIndex = 31;
            label4.Text = "Correo electronico:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(192, 136);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(279, 29);
            TxtEmail.TabIndex = 4;
            // 
            // AddEditorialForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(651, 195);
            Controls.Add(TxtEmail);
            Controls.Add(label4);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(MtbPhoneNumber);
            Controls.Add(TxtAdress);
            Controls.Add(TxtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 14F);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditorialForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Editorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnSave;
        private MaskedTextBox MtbPhoneNumber;
        private TextBox TxtAdress;
        private TextBox TxtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox TxtEmail;
    }
}
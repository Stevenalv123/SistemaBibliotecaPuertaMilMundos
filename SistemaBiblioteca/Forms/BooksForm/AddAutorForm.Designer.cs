namespace SistemaBiblioteca.Forms.BooksForm
{
    partial class AddAutorForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtNacionality = new TextBox();
            MtbBirthyear = new MaskedTextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(190, 26);
            label1.TabIndex = 0;
            label1.Text = "Nombre del autor: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 55);
            label2.Name = "label2";
            label2.Size = new Size(147, 26);
            label2.TabIndex = 0;
            label2.Text = "Nacionalidad: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 97);
            label3.Name = "label3";
            label3.Size = new Size(199, 26);
            label3.TabIndex = 0;
            label3.Text = "Año de nacimiento: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 13);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 33);
            txtName.TabIndex = 0;
            // 
            // txtNacionality
            // 
            txtNacionality.Location = new Point(203, 52);
            txtNacionality.Name = "txtNacionality";
            txtNacionality.Size = new Size(279, 33);
            txtNacionality.TabIndex = 1;
            // 
            // MtbBirthyear
            // 
            MtbBirthyear.BackColor = Color.White;
            MtbBirthyear.BeepOnError = true;
            MtbBirthyear.Font = new Font("Cambria", 15.75F);
            MtbBirthyear.HidePromptOnLeave = true;
            MtbBirthyear.Location = new Point(203, 94);
            MtbBirthyear.Mask = "0000";
            MtbBirthyear.Name = "MtbBirthyear";
            MtbBirthyear.PromptChar = ' ';
            MtbBirthyear.RejectInputOnFirstFailure = true;
            MtbBirthyear.Size = new Size(279, 32);
            MtbBirthyear.SkipLiterals = false;
            MtbBirthyear.TabIndex = 2;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(504, 57);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(40, 68, 131);
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(504, 11);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(133, 40);
            BtnSave.TabIndex = 22;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // AddAutorForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = BtnCancel;
            ClientSize = new Size(650, 151);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(MtbBirthyear);
            Controls.Add(txtNacionality);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 16F);
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(666, 190);
            MinimizeBox = false;
            MinimumSize = new Size(666, 190);
            Name = "AddAutorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Autor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtNacionality;
        private MaskedTextBox MtbBirthyear;
        private Button BtnCancel;
        private Button BtnSave;
    }
}
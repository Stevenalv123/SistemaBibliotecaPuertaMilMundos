namespace SistemaBiblioteca.Forms.DevolutionsForms
{
    partial class NewPrestamo
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
            label4 = new Label();
            TxtStudents = new TextBox();
            TxtBooks = new TextBox();
            DtpLoanDate = new DateTimePicker();
            DtpLoanDevolution = new DateTimePicker();
            LstStudents = new ListBox();
            BtnCancel = new Button();
            BtnSave = new FontAwesome.Sharp.IconButton();
            LstBooks = new ListBox();
            LblSelectedBooks = new Label();
            label5 = new Label();
            TxtObservations = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(213, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre del estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            label2.Location = new Point(54, 55);
            label2.Name = "label2";
            label2.Size = new Size(171, 22);
            label2.TabIndex = 1;
            label2.Text = "Libros que presta: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label3.Location = new Point(44, 93);
            label3.Name = "label3";
            label3.Size = new Size(181, 22);
            label3.TabIndex = 2;
            label3.Text = "Fecha de prestamo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            label4.Location = new Point(33, 131);
            label4.Name = "label4";
            label4.Size = new Size(192, 22);
            label4.TabIndex = 3;
            label4.Text = "Fecha de devolucion: ";
            // 
            // TxtStudents
            // 
            TxtStudents.Font = new Font("Cambria", 14F);
            TxtStudents.Location = new Point(230, 12);
            TxtStudents.Name = "TxtStudents";
            TxtStudents.PlaceholderText = "Nombre o Carnet";
            TxtStudents.Size = new Size(428, 29);
            TxtStudents.TabIndex = 4;
            TxtStudents.TextChanged += TxtStudents_TextChanged;
            // 
            // TxtBooks
            // 
            TxtBooks.Font = new Font("Cambria", 12F);
            TxtBooks.Location = new Point(230, 56);
            TxtBooks.Name = "TxtBooks";
            TxtBooks.Size = new Size(428, 26);
            TxtBooks.TabIndex = 5;
            TxtBooks.TextChanged += TxtBook_TextChanged;
            // 
            // DtpLoanDate
            // 
            DtpLoanDate.Font = new Font("Cambria", 12F);
            DtpLoanDate.Location = new Point(230, 94);
            DtpLoanDate.Name = "DtpLoanDate";
            DtpLoanDate.Size = new Size(428, 26);
            DtpLoanDate.TabIndex = 6;
            DtpLoanDate.ValueChanged += DtpLoanDate_ValueChanged;
            // 
            // DtpLoanDevolution
            // 
            DtpLoanDevolution.Font = new Font("Cambria", 12F);
            DtpLoanDevolution.Location = new Point(230, 132);
            DtpLoanDevolution.Name = "DtpLoanDevolution";
            DtpLoanDevolution.Size = new Size(428, 26);
            DtpLoanDevolution.TabIndex = 7;
            // 
            // LstStudents
            // 
            LstStudents.FormattingEnabled = true;
            LstStudents.ItemHeight = 15;
            LstStudents.Location = new Point(230, 47);
            LstStudents.Name = "LstStudents";
            LstStudents.Size = new Size(428, 124);
            LstStudents.TabIndex = 17;
            LstStudents.Visible = false;
            LstStudents.Click += LstStudents_Click;
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
            BtnCancel.Location = new Point(160, 307);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 20;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(40, 68, 131);
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnSave.ForeColor = Color.White;
            BtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnSave.IconColor = Color.White;
            BtnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnSave.IconSize = 30;
            BtnSave.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSave.Location = new Point(12, 307);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(133, 40);
            BtnSave.TabIndex = 22;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // LstBooks
            // 
            LstBooks.FormattingEnabled = true;
            LstBooks.ItemHeight = 15;
            LstBooks.Location = new Point(230, 88);
            LstBooks.Name = "LstBooks";
            LstBooks.Size = new Size(428, 169);
            LstBooks.TabIndex = 23;
            LstBooks.Visible = false;
            LstBooks.Click += LstBooks_Click;
            // 
            // LblSelectedBooks
            // 
            LblSelectedBooks.AutoSize = true;
            LblSelectedBooks.Location = new Point(525, 332);
            LblSelectedBooks.Name = "LblSelectedBooks";
            LblSelectedBooks.Size = new Size(0, 15);
            LblSelectedBooks.TabIndex = 26;
            LblSelectedBooks.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            label5.Location = new Point(77, 161);
            label5.Name = "label5";
            label5.Size = new Size(147, 22);
            label5.TabIndex = 29;
            label5.Text = "Observaciones: ";
            // 
            // TxtObservations
            // 
            TxtObservations.Font = new Font("Cambria", 10F);
            TxtObservations.Location = new Point(231, 164);
            TxtObservations.Multiline = true;
            TxtObservations.Name = "TxtObservations";
            TxtObservations.PlaceholderText = "(Opcional)";
            TxtObservations.Size = new Size(427, 109);
            TxtObservations.TabIndex = 30;
            // 
            // NewPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(673, 359);
            Controls.Add(LstStudents);
            Controls.Add(LstBooks);
            Controls.Add(TxtObservations);
            Controls.Add(label5);
            Controls.Add(LblSelectedBooks);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Controls.Add(DtpLoanDevolution);
            Controls.Add(DtpLoanDate);
            Controls.Add(TxtBooks);
            Controls.Add(TxtStudents);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewPrestamo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Devolucion";
            Load += NewPrestamo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtStudents;
        private TextBox TxtBooks;
        private DateTimePicker DtpLoanDate;
        private DateTimePicker DtpLoanDevolution;
        private ListBox LstStudents;
        private Button BtnCancel;
        private FontAwesome.Sharp.IconButton BtnSave;
        private ListBox LstBooks;
        private Label LblSelectedBooks;
        private Label label5;
        private TextBox TxtObservations;
    }
}
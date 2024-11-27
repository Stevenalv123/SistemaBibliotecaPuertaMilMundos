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
            BtnLookBooks = new FontAwesome.Sharp.IconButton();
            BtnCancel = new Button();
            BtnSave = new FontAwesome.Sharp.IconButton();
            LstBooks = new ListBox();
            BtnReady = new FontAwesome.Sharp.IconButton();
            LblSelectedBooks = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(213, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre del estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            label2.Location = new Point(53, 56);
            label2.Name = "label2";
            label2.Size = new Size(171, 22);
            label2.TabIndex = 1;
            label2.Text = "Libros que presta: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label3.Location = new Point(43, 94);
            label3.Name = "label3";
            label3.Size = new Size(181, 22);
            label3.TabIndex = 2;
            label3.Text = "Fecha de prestamo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            label4.Location = new Point(32, 132);
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
            TxtBooks.ReadOnly = true;
            TxtBooks.Size = new Size(289, 26);
            TxtBooks.TabIndex = 5;
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
            LstStudents.Size = new Size(428, 184);
            LstStudents.TabIndex = 17;
            LstStudents.Visible = false;
            LstStudents.Click += LstStudents_Click;
            // 
            // BtnLookBooks
            // 
            BtnLookBooks.Cursor = Cursors.Hand;
            BtnLookBooks.FlatAppearance.BorderSize = 0;
            BtnLookBooks.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnLookBooks.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnLookBooks.IconColor = Color.FromArgb(40, 68, 131);
            BtnLookBooks.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnLookBooks.IconSize = 26;
            BtnLookBooks.ImageAlign = ContentAlignment.TopLeft;
            BtnLookBooks.Location = new Point(525, 54);
            BtnLookBooks.Name = "BtnLookBooks";
            BtnLookBooks.Size = new Size(133, 28);
            BtnLookBooks.TabIndex = 19;
            BtnLookBooks.Text = "Ver libros  ";
            BtnLookBooks.UseVisualStyleBackColor = true;
            BtnLookBooks.Click += BtnLookBooks_Click;
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
            BtnCancel.Location = new Point(165, 399);
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
            BtnSave.Location = new Point(17, 399);
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
            LstBooks.Location = new Point(32, 209);
            LstBooks.Name = "LstBooks";
            LstBooks.SelectionMode = SelectionMode.MultiExtended;
            LstBooks.Size = new Size(491, 169);
            LstBooks.TabIndex = 23;
            LstBooks.Visible = false;
            LstBooks.SelectedIndexChanged += LstBooks_SelectedIndexChanged;
            // 
            // BtnReady
            // 
            BtnReady.BackColor = Color.FromArgb(40, 68, 131);
            BtnReady.Cursor = Cursors.Hand;
            BtnReady.FlatAppearance.BorderSize = 0;
            BtnReady.FlatStyle = FlatStyle.Flat;
            BtnReady.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnReady.ForeColor = Color.White;
            BtnReady.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnReady.IconColor = Color.White;
            BtnReady.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnReady.IconSize = 26;
            BtnReady.ImageAlign = ContentAlignment.TopLeft;
            BtnReady.Location = new Point(529, 179);
            BtnReady.Name = "BtnReady";
            BtnReady.Size = new Size(129, 32);
            BtnReady.TabIndex = 24;
            BtnReady.Text = "Listo";
            BtnReady.UseVisualStyleBackColor = false;
            BtnReady.Visible = false;
            BtnReady.Click += BtnReady_Click;
            // 
            // LblSelectedBooks
            // 
            LblSelectedBooks.AutoSize = true;
            LblSelectedBooks.Location = new Point(529, 218);
            LblSelectedBooks.Name = "LblSelectedBooks";
            LblSelectedBooks.Size = new Size(0, 15);
            LblSelectedBooks.TabIndex = 26;
            LblSelectedBooks.Visible = false;
            // 
            // TxtSearch
            // 
            TxtSearch.Font = new Font("Segoe UI", 12F);
            TxtSearch.Location = new Point(32, 179);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Buscar autor";
            TxtSearch.Size = new Size(491, 29);
            TxtSearch.TabIndex = 27;
            TxtSearch.Visible = false;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // BtnSearch
            // 
            BtnSearch.Cursor = Cursors.Hand;
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnSearch.IconColor = Color.Black;
            BtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSearch.IconSize = 24;
            BtnSearch.Location = new Point(497, 183);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(22, 18);
            BtnSearch.TabIndex = 28;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Visible = false;
            // 
            // NewPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(668, 450);
            Controls.Add(LstStudents);
            Controls.Add(BtnSearch);
            Controls.Add(TxtSearch);
            Controls.Add(LblSelectedBooks);
            Controls.Add(BtnReady);
            Controls.Add(LstBooks);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Controls.Add(BtnLookBooks);
            Controls.Add(DtpLoanDevolution);
            Controls.Add(DtpLoanDate);
            Controls.Add(TxtBooks);
            Controls.Add(TxtStudents);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(684, 489);
            MinimizeBox = false;
            MinimumSize = new Size(684, 489);
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
        private FontAwesome.Sharp.IconButton BtnLookBooks;
        private Button BtnCancel;
        private FontAwesome.Sharp.IconButton BtnSave;
        private ListBox LstBooks;
        private FontAwesome.Sharp.IconButton BtnReady;
        private Label LblSelectedBooks;
        private TextBox TxtSearch;
        private FontAwesome.Sharp.IconButton BtnSearch;
    }
}
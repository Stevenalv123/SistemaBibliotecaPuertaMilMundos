namespace SistemaBiblioteca.Forms.Books
{
    partial class AddBooks
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
            label5 = new Label();
            label6 = new Label();
            TxtTitle = new TextBox();
            MtbISBN = new MaskedTextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label7 = new Label();
            BtnLookAuthor = new FontAwesome.Sharp.IconButton();
            BtnAddEditorial = new FontAwesome.Sharp.IconButton();
            MtbPublicationYear = new MaskedTextBox();
            MtbStock = new MaskedTextBox();
            CmbEditorial = new Syncfusion.WinForms.ListView.SfComboBox();
            LblIconFormat = new Label();
            LblFormatStatus = new Label();
            CmbCategories = new Syncfusion.WinForms.ListView.SfComboBox();
            BtnAddCategorie = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            TxtAuthors = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CmbEditorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CmbCategories).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label1.Location = new Point(149, 14);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Titulo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label2.Location = new Point(153, 65);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 1;
            label2.Text = "Autor: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label3.Location = new Point(164, 160);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 2;
            label3.Text = "ISBN: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label4.Location = new Point(118, 210);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 3;
            label4.Text = "Editorial: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label5.Location = new Point(7, 260);
            label5.Name = "label5";
            label5.Size = new Size(233, 28);
            label5.TabIndex = 4;
            label5.Text = "Año de publicacion: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label6.Location = new Point(81, 309);
            label6.Name = "label6";
            label6.Size = new Size(159, 28);
            label6.TabIndex = 5;
            label6.Text = "Stock Actual: ";
            // 
            // TxtTitle
            // 
            TxtTitle.BackColor = Color.White;
            TxtTitle.Font = new Font("Cambria", 15.75F);
            TxtTitle.Location = new Point(261, 12);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(450, 32);
            TxtTitle.TabIndex = 6;
            TxtTitle.TextChanged += TxtTitle_TextChanged;
            // 
            // MtbISBN
            // 
            MtbISBN.BackColor = Color.White;
            MtbISBN.BeepOnError = true;
            MtbISBN.Font = new Font("Cambria", 15.75F);
            MtbISBN.HidePromptOnLeave = true;
            MtbISBN.Location = new Point(261, 158);
            MtbISBN.Mask = "000-0-00-000000-0";
            MtbISBN.Name = "MtbISBN";
            MtbISBN.PromptChar = ' ';
            MtbISBN.RejectInputOnFirstFailure = true;
            MtbISBN.Size = new Size(200, 32);
            MtbISBN.TabIndex = 8;
            MtbISBN.TextChanged += MtbISBN_TextChanged;
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
            BtnCancel.Location = new Point(453, 389);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 12;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(40, 68, 131);
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.DialogResult = DialogResult.OK;
            BtnSave.Enabled = false;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(603, 389);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(133, 40);
            BtnSave.TabIndex = 13;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 18F);
            label7.Location = new Point(411, 307);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 14;
            label7.Text = "Unidades";
            // 
            // BtnLookAuthor
            // 
            BtnLookAuthor.Cursor = Cursors.Hand;
            BtnLookAuthor.FlatAppearance.BorderSize = 0;
            BtnLookAuthor.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnLookAuthor.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnLookAuthor.IconColor = Color.FromArgb(40, 68, 131);
            BtnLookAuthor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnLookAuthor.IconSize = 26;
            BtnLookAuthor.ImageAlign = ContentAlignment.TopLeft;
            BtnLookAuthor.Location = new Point(582, 63);
            BtnLookAuthor.Name = "BtnLookAuthor";
            BtnLookAuthor.Size = new Size(129, 32);
            BtnLookAuthor.TabIndex = 15;
            BtnLookAuthor.Text = "Ver Autores     ";
            BtnLookAuthor.TextAlign = ContentAlignment.MiddleRight;
            BtnLookAuthor.UseVisualStyleBackColor = true;
            BtnLookAuthor.Click += BtnAddAuthor_Click;
            // 
            // BtnAddEditorial
            // 
            BtnAddEditorial.Cursor = Cursors.Hand;
            BtnAddEditorial.FlatAppearance.BorderSize = 0;
            BtnAddEditorial.Font = new Font("Cambria", 8F, FontStyle.Bold);
            BtnAddEditorial.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtnAddEditorial.IconColor = Color.Green;
            BtnAddEditorial.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnAddEditorial.IconSize = 26;
            BtnAddEditorial.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAddEditorial.Location = new Point(582, 210);
            BtnAddEditorial.Name = "BtnAddEditorial";
            BtnAddEditorial.Size = new Size(129, 32);
            BtnAddEditorial.TabIndex = 17;
            BtnAddEditorial.Text = "Agregar Editorial";
            BtnAddEditorial.TextAlign = ContentAlignment.MiddleRight;
            BtnAddEditorial.UseVisualStyleBackColor = true;
            BtnAddEditorial.Click += BtnAddEditorial_Click;
            // 
            // MtbPublicationYear
            // 
            MtbPublicationYear.BackColor = Color.White;
            MtbPublicationYear.BeepOnError = true;
            MtbPublicationYear.Font = new Font("Cambria", 15.75F);
            MtbPublicationYear.HidePromptOnLeave = true;
            MtbPublicationYear.Location = new Point(261, 256);
            MtbPublicationYear.Mask = "0000";
            MtbPublicationYear.Name = "MtbPublicationYear";
            MtbPublicationYear.PromptChar = ' ';
            MtbPublicationYear.RejectInputOnFirstFailure = true;
            MtbPublicationYear.Size = new Size(144, 32);
            MtbPublicationYear.SkipLiterals = false;
            MtbPublicationYear.TabIndex = 19;
            // 
            // MtbStock
            // 
            MtbStock.BackColor = Color.White;
            MtbStock.BeepOnError = true;
            MtbStock.Font = new Font("Cambria", 15.75F);
            MtbStock.HidePromptOnLeave = true;
            MtbStock.Location = new Point(261, 309);
            MtbStock.Mask = "0000000000";
            MtbStock.Name = "MtbStock";
            MtbStock.PromptChar = ' ';
            MtbStock.RejectInputOnFirstFailure = true;
            MtbStock.Size = new Size(144, 32);
            MtbStock.SkipLiterals = false;
            MtbStock.TabIndex = 20;
            // 
            // CmbEditorial
            // 
            CmbEditorial.AutoCompleteMode = AutoCompleteMode.Suggest;
            CmbEditorial.BackColor = Color.White;
            CmbEditorial.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            CmbEditorial.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            CmbEditorial.Location = new Point(261, 210);
            CmbEditorial.Name = "CmbEditorial";
            CmbEditorial.Size = new Size(305, 32);
            CmbEditorial.Style.EditorStyle.BackColor = Color.White;
            CmbEditorial.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            CmbEditorial.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            CmbEditorial.TabIndex = 18;
            CmbEditorial.Watermark = "S/E";
            // 
            // LblIconFormat
            // 
            LblIconFormat.AutoSize = true;
            LblIconFormat.Font = new Font("Cambria", 12F, FontStyle.Bold);
            LblIconFormat.Location = new Point(461, 166);
            LblIconFormat.Name = "LblIconFormat";
            LblIconFormat.Size = new Size(0, 19);
            LblIconFormat.TabIndex = 21;
            // 
            // LblFormatStatus
            // 
            LblFormatStatus.AutoSize = true;
            LblFormatStatus.Font = new Font("Cambria", 9F, FontStyle.Bold);
            LblFormatStatus.Location = new Point(481, 170);
            LblFormatStatus.Name = "LblFormatStatus";
            LblFormatStatus.Size = new Size(0, 14);
            LblFormatStatus.TabIndex = 22;
            // 
            // CmbCategories
            // 
            CmbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            CmbCategories.BackColor = Color.White;
            CmbCategories.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            CmbCategories.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            CmbCategories.Location = new Point(261, 110);
            CmbCategories.Name = "CmbCategories";
            CmbCategories.Size = new Size(305, 32);
            CmbCategories.Style.EditorStyle.BackColor = Color.White;
            CmbCategories.Style.ReadOnlyEditorStyle.BackColor = Color.White;
            CmbCategories.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            CmbCategories.TabIndex = 25;
            CmbCategories.Watermark = "S/E";
            // 
            // BtnAddCategorie
            // 
            BtnAddCategorie.Cursor = Cursors.Hand;
            BtnAddCategorie.FlatAppearance.BorderSize = 0;
            BtnAddCategorie.Font = new Font("Cambria", 9F, FontStyle.Bold);
            BtnAddCategorie.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtnAddCategorie.IconColor = Color.Green;
            BtnAddCategorie.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnAddCategorie.IconSize = 26;
            BtnAddCategorie.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAddCategorie.Location = new Point(582, 110);
            BtnAddCategorie.Name = "BtnAddCategorie";
            BtnAddCategorie.Size = new Size(129, 32);
            BtnAddCategorie.TabIndex = 24;
            BtnAddCategorie.Text = "Nueva Categoria";
            BtnAddCategorie.TextAlign = ContentAlignment.MiddleRight;
            BtnAddCategorie.UseVisualStyleBackColor = true;
            BtnAddCategorie.Click += BtnAddCategorie_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label8.Location = new Point(109, 110);
            label8.Name = "label8";
            label8.Size = new Size(131, 28);
            label8.TabIndex = 23;
            label8.Text = "Categoria: ";
            // 
            // TxtAuthors
            // 
            TxtAuthors.BackColor = Color.White;
            TxtAuthors.Font = new Font("Cambria", 15.75F);
            TxtAuthors.Location = new Point(261, 65);
            TxtAuthors.Name = "TxtAuthors";
            TxtAuthors.ReadOnly = true;
            TxtAuthors.Size = new Size(305, 32);
            TxtAuthors.TabIndex = 26;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(748, 441);
            Controls.Add(TxtAuthors);
            Controls.Add(CmbCategories);
            Controls.Add(BtnAddCategorie);
            Controls.Add(label8);
            Controls.Add(LblFormatStatus);
            Controls.Add(LblIconFormat);
            Controls.Add(MtbStock);
            Controls.Add(MtbPublicationYear);
            Controls.Add(CmbEditorial);
            Controls.Add(BtnAddEditorial);
            Controls.Add(BtnLookAuthor);
            Controls.Add(label7);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(MtbISBN);
            Controls.Add(TxtTitle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(764, 427);
            Name = "AddBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Libro";
            ((System.ComponentModel.ISupportInitialize)CmbEditorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)CmbCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtTitle;
        private MaskedTextBox MtbISBN;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label7;
        private FontAwesome.Sharp.IconButton BtnLookAuthor;
        private FontAwesome.Sharp.IconButton BtnAddEditorial;
        private MaskedTextBox MtbPublicationYear;
        private MaskedTextBox MtbStock;
        private Syncfusion.WinForms.ListView.SfComboBox CmbEditorial;
        private Label LblIconFormat;
        private Label LblFormatStatus;
        private Syncfusion.WinForms.ListView.SfComboBox CmbCategories;
        private FontAwesome.Sharp.IconButton BtnAddCategorie;
        private Label label8;
        private TextBox TxtAuthors;
    }
}
namespace SistemaBiblioteca.Forms.DevolutionsForms
{
    partial class ConditionsForms
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
            groupBox1 = new GroupBox();
            RbtnDañado = new RadioButton();
            RbtnRegular = new RadioButton();
            RbtnBuen = new RadioButton();
            BtnAccept = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RbtnDañado);
            groupBox1.Controls.Add(RbtnRegular);
            groupBox1.Controls.Add(RbtnBuen);
            groupBox1.Font = new Font("Cambria", 14F, FontStyle.Bold);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 132);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Condicion de devolucion del libro";
            // 
            // RbtnDañado
            // 
            RbtnDañado.AutoSize = true;
            RbtnDañado.Font = new Font("Cambria", 12F);
            RbtnDañado.Location = new Point(6, 90);
            RbtnDañado.Name = "RbtnDañado";
            RbtnDañado.Size = new Size(81, 23);
            RbtnDañado.TabIndex = 1;
            RbtnDañado.TabStop = true;
            RbtnDañado.Text = "Dañado";
            RbtnDañado.UseVisualStyleBackColor = true;
            // 
            // RbtnRegular
            // 
            RbtnRegular.AutoSize = true;
            RbtnRegular.Font = new Font("Cambria", 12F);
            RbtnRegular.Location = new Point(6, 59);
            RbtnRegular.Name = "RbtnRegular";
            RbtnRegular.Size = new Size(81, 23);
            RbtnRegular.TabIndex = 1;
            RbtnRegular.TabStop = true;
            RbtnRegular.Text = "Regular";
            RbtnRegular.UseVisualStyleBackColor = true;
            // 
            // RbtnBuen
            // 
            RbtnBuen.AutoSize = true;
            RbtnBuen.Font = new Font("Cambria", 12F);
            RbtnBuen.Location = new Point(6, 28);
            RbtnBuen.Name = "RbtnBuen";
            RbtnBuen.Size = new Size(113, 23);
            RbtnBuen.TabIndex = 1;
            RbtnBuen.TabStop = true;
            RbtnBuen.Text = "Buen estado";
            RbtnBuen.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            BtnAccept.BackColor = Color.MidnightBlue;
            BtnAccept.FlatAppearance.BorderSize = 0;
            BtnAccept.FlatStyle = FlatStyle.Flat;
            BtnAccept.Font = new Font("Cambria", 12F, FontStyle.Bold);
            BtnAccept.ForeColor = Color.White;
            BtnAccept.Location = new Point(213, 169);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(134, 46);
            BtnAccept.TabIndex = 2;
            BtnAccept.Text = "Aceptar";
            BtnAccept.UseVisualStyleBackColor = false;
            BtnAccept.Click += BtnAccept_Click;
            // 
            // ConditionsForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 225);
            Controls.Add(BtnAccept);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(380, 264);
            MinimizeBox = false;
            MinimumSize = new Size(380, 264);
            Name = "ConditionsForms";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Condicion de devolucion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton RbtnDañado;
        private RadioButton RbtnRegular;
        private RadioButton RbtnBuen;
        private Button BtnAccept;
    }
}
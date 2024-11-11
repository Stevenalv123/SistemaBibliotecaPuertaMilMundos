namespace SistemaBiblioteca.Forms
{
    partial class ExitForm
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
            TopPanel = new Panel();
            LblTitle = new Label();
            MainPanel = new Panel();
            LblQuestion = new Label();
            BottomPanel = new Panel();
            BtnCancel = new Button();
            BtnExit = new Button();
            TopPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(40, 68, 131);
            TopPanel.Controls.Add(LblTitle);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(517, 48);
            TopPanel.TabIndex = 0;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.ForeColor = Color.White;
            LblTitle.Location = new Point(12, 9);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(203, 26);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Salir del Programa";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(LblQuestion);
            MainPanel.Dock = DockStyle.Top;
            MainPanel.Location = new Point(0, 48);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(517, 54);
            MainPanel.TabIndex = 1;
            // 
            // LblQuestion
            // 
            LblQuestion.AutoSize = true;
            LblQuestion.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblQuestion.Location = new Point(53, 16);
            LblQuestion.Name = "LblQuestion";
            LblQuestion.Size = new Size(411, 22);
            LblQuestion.TabIndex = 0;
            LblQuestion.Text = "¿Estas seguro que quieres salir del Programa?";
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(BtnCancel);
            BottomPanel.Controls.Add(BtnExit);
            BottomPanel.Dock = DockStyle.Fill;
            BottomPanel.Location = new Point(0, 102);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(517, 61);
            BottomPanel.TabIndex = 2;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(185, 27, 33);
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(233, 10);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 40);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.FromArgb(40, 68, 131);
            BtnExit.Cursor = Cursors.Hand;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Cambria", 10F, FontStyle.Bold);
            BtnExit.ForeColor = Color.White;
            BtnExit.Location = new Point(372, 10);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(133, 40);
            BtnExit.TabIndex = 7;
            BtnExit.Text = "Salir";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // Exit
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 163);
            Controls.Add(BottomPanel);
            Controls.Add(MainPanel);
            Controls.Add(TopPanel);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Exit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salir";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel MainPanel;
        private Panel BottomPanel;
        private Label LblTitle;
        private Label LblQuestion;
        private Button BtnCancel;
        private Button BtnExit;
    }
}
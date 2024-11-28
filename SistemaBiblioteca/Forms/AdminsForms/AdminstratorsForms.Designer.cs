namespace SistemaBiblioteca.Forms.AdminsForms
{
    partial class AdminstratorsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminstratorsForms));
            panel1 = new Panel();
            ToolBoxUsers = new ToolStrip();
            TsbAddStudent = new ToolStripButton();
            panel2 = new Panel();
            FlpAdmins = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ToolBoxUsers.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ToolBoxUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 49);
            panel1.TabIndex = 1;
            // 
            // ToolBoxUsers
            // 
            ToolBoxUsers.BackColor = Color.LightGray;
            ToolBoxUsers.Dock = DockStyle.Fill;
            ToolBoxUsers.Items.AddRange(new ToolStripItem[] { TsbAddStudent });
            ToolBoxUsers.Location = new Point(0, 0);
            ToolBoxUsers.Name = "ToolBoxUsers";
            ToolBoxUsers.Size = new Size(931, 49);
            ToolBoxUsers.TabIndex = 1;
            ToolBoxUsers.Text = "toolStrip1";
            // 
            // TsbAddStudent
            // 
            TsbAddStudent.Alignment = ToolStripItemAlignment.Right;
            TsbAddStudent.Font = new Font("Cambria", 11F, FontStyle.Bold);
            TsbAddStudent.Image = (Image)resources.GetObject("TsbAddStudent.Image");
            TsbAddStudent.ImageTransparentColor = Color.Magenta;
            TsbAddStudent.Name = "TsbAddStudent";
            TsbAddStudent.Size = new Size(72, 46);
            TsbAddStudent.Text = "Nuevo";
            TsbAddStudent.Click += TsbAddStudent_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(FlpAdmins);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 581);
            panel2.TabIndex = 2;
            // 
            // FlpAdmins
            // 
            FlpAdmins.Dock = DockStyle.Fill;
            FlpAdmins.Location = new Point(0, 0);
            FlpAdmins.Name = "FlpAdmins";
            FlpAdmins.Size = new Size(931, 581);
            FlpAdmins.TabIndex = 1;
            // 
            // AdminstratorsForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(931, 630);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminstratorsForms";
            Text = "AdminstratorsForms";
            Load += AdminstratorsForms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ToolBoxUsers.ResumeLayout(false);
            ToolBoxUsers.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ToolStrip ToolBoxUsers;
        private ToolStripButton TsbAddStudent;
        private Panel panel2;
        private FlowLayoutPanel FlpAdmins;
    }
}
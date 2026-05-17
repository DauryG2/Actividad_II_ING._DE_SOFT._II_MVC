namespace Actividad_II___Ingenieria_de_software_II___MVC.VISTA
{
    partial class Student
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
            menuStrip = new MenuStrip();
            crearUsuariosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { crearUsuariosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(375, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            crearUsuariosToolStripMenuItem.Size = new Size(12, 20);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.IndianRed;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(32, 19);
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(32, 19);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(90, 108);
            label1.Name = "label1";
            label1.Size = new Size(192, 26);
            label1.TabIndex = 1;
            label1.Text = "USTED ES ESTUDIANTE";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 237);
            Controls.Add(label1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Student";
            Text = "Student";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private Label label1;
    }
}
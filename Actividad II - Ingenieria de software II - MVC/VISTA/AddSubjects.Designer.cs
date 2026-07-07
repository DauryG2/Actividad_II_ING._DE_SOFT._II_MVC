namespace Actividad_II___Ingenieria_de_software_II___MVC.VISTA
{
    partial class AddSubjects
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
            subjectsBox = new TextBox();
            CreateBtn = new Button();
            UpdateBtn = new Button();
            dtSubjects = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtSubjects).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Materia";
            // 
            // subjectsBox
            // 
            subjectsBox.Location = new Point(19, 36);
            subjectsBox.Name = "subjectsBox";
            subjectsBox.Size = new Size(100, 23);
            subjectsBox.TabIndex = 4;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.YellowGreen;
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Impact", 12F);
            CreateBtn.ForeColor = Color.Transparent;
            CreateBtn.Location = new Point(19, 270);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(100, 42);
            CreateBtn.TabIndex = 7;
            CreateBtn.Text = "Crear";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.DodgerBlue;
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Impact", 12F);
            UpdateBtn.ForeColor = Color.Transparent;
            UpdateBtn.Location = new Point(19, 222);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(100, 42);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Actualizar";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // dtSubjects
            // 
            dtSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSubjects.Location = new Point(137, 36);
            dtSubjects.Name = "dtSubjects";
            dtSubjects.Size = new Size(359, 276);
            dtSubjects.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 20);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 12;
            label3.Text = "Materia";
            // 
            // AddSubjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 330);
            Controls.Add(label3);
            Controls.Add(dtSubjects);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(subjectsBox);
            Controls.Add(label1);
            Name = "AddSubjects";
            Text = "Añadir materias";
            ((System.ComponentModel.ISupportInitialize)dtSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox subjectsBox;
        private Button CreateBtn;
        private Button UpdateBtn;
        private DataGridView dtSubjects;
        private Label label3;
    }
}
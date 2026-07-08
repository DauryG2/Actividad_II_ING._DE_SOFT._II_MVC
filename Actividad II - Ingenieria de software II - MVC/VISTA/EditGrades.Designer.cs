namespace Actividad_II___Ingenieria_de_software_II___MVC.VISTA
{
    partial class EditGrades
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
            idBox = new TextBox();
            applyBtn = new Button();
            UpdateBtn = new Button();
            dtGrades = new DataGridView();
            label3 = new Label();
            subjectBox = new TextBox();
            label2 = new Label();
            gradesBox = new TextBox();
            label4 = new Label();
            dtUsers = new DataGridView();
            label5 = new Label();
            dtSubject = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGrades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtSubject).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Id de usuario";
            // 
            // idBox
            // 
            idBox.Location = new Point(19, 36);
            idBox.Name = "idBox";
            idBox.Size = new Size(100, 23);
            idBox.TabIndex = 4;
            // 
            // applyBtn
            // 
            applyBtn.BackColor = Color.YellowGreen;
            applyBtn.FlatStyle = FlatStyle.Popup;
            applyBtn.Font = new Font("Impact", 12F);
            applyBtn.ForeColor = Color.Transparent;
            applyBtn.Location = new Point(19, 270);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(100, 42);
            applyBtn.TabIndex = 7;
            applyBtn.Text = "Editar";
            applyBtn.UseVisualStyleBackColor = false;
            applyBtn.Click += CreateBtn_Click;
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
            // dtGrades
            // 
            dtGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrades.Location = new Point(137, 36);
            dtGrades.Name = "dtGrades";
            dtGrades.Size = new Size(470, 276);
            dtGrades.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 20);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 12;
            label3.Text = "Materia y calificaciones";
            // 
            // subjectBox
            // 
            subjectBox.Location = new Point(19, 80);
            subjectBox.Name = "subjectBox";
            subjectBox.Size = new Size(100, 23);
            subjectBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 62);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 13;
            label2.Text = "Id de materia";
            // 
            // gradesBox
            // 
            gradesBox.Location = new Point(19, 124);
            gradesBox.Name = "gradesBox";
            gradesBox.Size = new Size(100, 23);
            gradesBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 106);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 15;
            label4.Text = "Nota";
            // 
            // dtUsers
            // 
            dtUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtUsers.Location = new Point(12, 337);
            dtUsers.Name = "dtUsers";
            dtUsers.Size = new Size(355, 156);
            dtUsers.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 319);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 18;
            label5.Text = "Usuarios";
            // 
            // dtSubject
            // 
            dtSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSubject.Location = new Point(385, 337);
            dtSubject.Name = "dtSubject";
            dtSubject.Size = new Size(222, 156);
            dtSubject.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 319);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 20;
            label6.Text = "Materias";
            // 
            // EditGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 514);
            Controls.Add(label6);
            Controls.Add(dtSubject);
            Controls.Add(label5);
            Controls.Add(dtUsers);
            Controls.Add(gradesBox);
            Controls.Add(label4);
            Controls.Add(subjectBox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(dtGrades);
            Controls.Add(UpdateBtn);
            Controls.Add(applyBtn);
            Controls.Add(idBox);
            Controls.Add(label1);
            Name = "EditGrades";
            Text = "Editar calificaciones";
            ((System.ComponentModel.ISupportInitialize)dtGrades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox idBox;
        private Button applyBtn;
        private Button UpdateBtn;
        private DataGridView dtGrades;
        private Label label3;
        private TextBox subjectBox;
        private Label label2;
        private TextBox gradesBox;
        private Label label4;
        private DataGridView dtUsers;
        private Label label5;
        private DataGridView dtSubject;
        private Label label6;
        private Button deleteBtn;
    }
}
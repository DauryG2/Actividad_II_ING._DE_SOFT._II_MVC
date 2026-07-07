namespace Actividad_II___Ingenieria_de_software_II___MVC.VISTA
{
    partial class Grades
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
            EditBtn = new Button();
            CreateBtn = new Button();
            Back = new LinkLabel();
            UpdateBtn = new Button();
            ShowUsers = new DataGridView();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowUsers).BeginInit();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Gold;
            EditBtn.FlatStyle = FlatStyle.Popup;
            EditBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.Transparent;
            EditBtn.Location = new Point(522, 132);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(114, 40);
            EditBtn.TabIndex = 11;
            EditBtn.Text = "Editar";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.YellowGreen;
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateBtn.ForeColor = Color.Transparent;
            CreateBtn.Location = new Point(522, 86);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(114, 40);
            CreateBtn.TabIndex = 10;
            CreateBtn.Text = "Añadir";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Location = new Point(597, 10);
            Back.Name = "Back";
            Back.Size = new Size(39, 15);
            Back.TabIndex = 8;
            Back.TabStop = true;
            Back.Text = "Volver";
            Back.LinkClicked += Back_LinkClicked;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.DodgerBlue;
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Transparent;
            UpdateBtn.Location = new Point(522, 40);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(114, 40);
            UpdateBtn.TabIndex = 7;
            UpdateBtn.Text = "Actualizar";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ShowUsers
            // 
            ShowUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowUsers.Location = new Point(21, 40);
            ShowUsers.Name = "ShowUsers";
            ShowUsers.Size = new Size(481, 305);
            ShowUsers.TabIndex = 6;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.Transparent;
            deleteBtn.Location = new Point(522, 178);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(114, 40);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Eliminar";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 361);
            Controls.Add(deleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(CreateBtn);
            Controls.Add(Back);
            Controls.Add(UpdateBtn);
            Controls.Add(ShowUsers);
            Name = "Grades";
            Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)ShowUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private Button CreateBtn;
        private LinkLabel Back;
        private Button UpdateBtn;
        private DataGridView ShowUsers;
        private Button deleteBtn;
    }
}
namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    partial class MonitorAdmin
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
            ShowUsers = new DataGridView();
            UpdateBtn = new Button();
            Back = new LinkLabel();
            DeleteBtn = new Button();
            CreateBtn = new Button();
            EditBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowUsers).BeginInit();
            SuspendLayout();
            // 
            // ShowUsers
            // 
            ShowUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowUsers.Location = new Point(21, 40);
            ShowUsers.Name = "ShowUsers";
            ShowUsers.Size = new Size(529, 324);
            ShowUsers.TabIndex = 0;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.DodgerBlue;
            UpdateBtn.FlatStyle = FlatStyle.Popup;
            UpdateBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Transparent;
            UpdateBtn.Location = new Point(569, 40);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(114, 40);
            UpdateBtn.TabIndex = 1;
            UpdateBtn.Text = "Actualizar";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += button1_Click;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Location = new Point(644, 10);
            Back.Name = "Back";
            Back.Size = new Size(39, 15);
            Back.TabIndex = 2;
            Back.TabStop = true;
            Back.Text = "Volver";
            Back.LinkClicked += Back_LinkClicked;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.FlatStyle = FlatStyle.Popup;
            DeleteBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.Transparent;
            DeleteBtn.Location = new Point(569, 178);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(114, 40);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Eliminar";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.YellowGreen;
            CreateBtn.FlatStyle = FlatStyle.Popup;
            CreateBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateBtn.ForeColor = Color.Transparent;
            CreateBtn.Location = new Point(569, 86);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(114, 40);
            CreateBtn.TabIndex = 4;
            CreateBtn.Text = "Crear";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Gold;
            EditBtn.FlatStyle = FlatStyle.Popup;
            EditBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.Transparent;
            EditBtn.Location = new Point(569, 132);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(114, 40);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "Editar";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // MonitorAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 388);
            Controls.Add(EditBtn);
            Controls.Add(CreateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(Back);
            Controls.Add(UpdateBtn);
            Controls.Add(ShowUsers);
            Name = "MonitorAdmin";
            Text = "Monitor Admin";
            ((System.ComponentModel.ISupportInitialize)ShowUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ShowUsers;
        private Button UpdateBtn;
        private LinkLabel Back;
        private Button DeleteBtn;
        private Button CreateBtn;
        private Button EditBtn;
    }
}
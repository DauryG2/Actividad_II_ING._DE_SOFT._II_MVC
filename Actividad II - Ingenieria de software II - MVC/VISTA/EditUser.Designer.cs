namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    partial class EditUser
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
            nameBox = new TextBox();
            lastnameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtUsers = new DataGridView();
            button1 = new Button();
            userBox = new TextBox();
            rolBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtUsers).BeginInit();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 101);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(121, 23);
            nameBox.TabIndex = 1;
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(12, 151);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(121, 23);
            lastnameBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 8;
            label4.Text = "Rol";
            // 
            // dtUsers
            // 
            dtUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtUsers.Location = new Point(149, 25);
            dtUsers.Name = "dtUsers";
            dtUsers.Size = new Size(400, 258);
            dtUsers.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Impact", 12F);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(12, 241);
            button1.Name = "button1";
            button1.Size = new Size(121, 42);
            button1.TabIndex = 11;
            button1.Text = "Aplicar cambios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // userBox
            // 
            userBox.Location = new Point(12, 51);
            userBox.Name = "userBox";
            userBox.Size = new Size(121, 23);
            userBox.TabIndex = 12;
            // 
            // rolBox
            // 
            rolBox.Location = new Point(12, 201);
            rolBox.Name = "rolBox";
            rolBox.Size = new Size(121, 23);
            rolBox.TabIndex = 13;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 308);
            Controls.Add(rolBox);
            Controls.Add(userBox);
            Controls.Add(button1);
            Controls.Add(dtUsers);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastnameBox);
            Controls.Add(nameBox);
            Name = "EditUser";
            Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)dtUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameBox;
        private TextBox lastnameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dtUsers;
        private Button button1;
        private TextBox userBox;
        private TextBox rolBox;
    }
}
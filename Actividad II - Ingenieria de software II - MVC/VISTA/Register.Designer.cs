namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            NameBox = new TextBox();
            labelName = new Label();
            Last_name = new Label();
            Last_nameBox = new TextBox();
            User = new Label();
            UserBox = new TextBox();
            Password = new Label();
            PasswordBox = new TextBox();
            RolChoice = new Label();
            RolsCombo = new ComboBox();
            pictureBox1 = new PictureBox();
            Title = new Label();
            Back = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(50, 58);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(148, 23);
            NameBox.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(50, 40);
            labelName.Name = "labelName";
            labelName.Size = new Size(51, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Nombre";
            // 
            // Last_name
            // 
            Last_name.AutoSize = true;
            Last_name.Location = new Point(50, 88);
            Last_name.Name = "Last_name";
            Last_name.Size = new Size(51, 15);
            Last_name.TabIndex = 3;
            Last_name.Text = "Apellido";
            // 
            // Last_nameBox
            // 
            Last_nameBox.Location = new Point(50, 106);
            Last_nameBox.Name = "Last_nameBox";
            Last_nameBox.Size = new Size(148, 23);
            Last_nameBox.TabIndex = 2;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(50, 136);
            User.Name = "User";
            User.Size = new Size(47, 15);
            User.TabIndex = 5;
            User.Text = "Usuario";
            // 
            // UserBox
            // 
            UserBox.Location = new Point(50, 154);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(148, 23);
            UserBox.TabIndex = 4;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(50, 184);
            Password.Name = "Password";
            Password.Size = new Size(67, 15);
            Password.TabIndex = 7;
            Password.Text = "Contraseña";
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(50, 202);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(148, 23);
            PasswordBox.TabIndex = 6;
            // 
            // RolChoice
            // 
            RolChoice.AutoSize = true;
            RolChoice.Location = new Point(50, 234);
            RolChoice.Name = "RolChoice";
            RolChoice.Size = new Size(24, 15);
            RolChoice.TabIndex = 9;
            RolChoice.Text = "Rol";
            // 
            // RolsCombo
            // 
            RolsCombo.FormattingEnabled = true;
            RolsCombo.Location = new Point(50, 250);
            RolsCombo.Name = "RolsCombo";
            RolsCombo.Size = new Size(148, 23);
            RolsCombo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Cursor = Cursors.Hand;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Brown;
            Title.Location = new Point(263, 246);
            Title.Name = "Title";
            Title.Size = new Size(105, 28);
            Title.TabIndex = 12;
            Title.Text = "REGISTRAR";
            Title.Click += Title_Click;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Location = new Point(385, 22);
            Back.Name = "Back";
            Back.Size = new Size(34, 15);
            Back.TabIndex = 13;
            Back.TabStop = true;
            Back.Text = "Atras";
            Back.LinkClicked += Back_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 322);
            Controls.Add(Back);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Controls.Add(RolsCombo);
            Controls.Add(RolChoice);
            Controls.Add(Password);
            Controls.Add(PasswordBox);
            Controls.Add(User);
            Controls.Add(UserBox);
            Controls.Add(Last_name);
            Controls.Add(Last_nameBox);
            Controls.Add(labelName);
            Controls.Add(NameBox);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private Label labelName;
        private Label Last_name;
        private TextBox Last_nameBox;
        private Label User;
        private TextBox UserBox;
        private Label Password;
        private TextBox PasswordBox;
        private Label RolChoice;
        private ComboBox RolsCombo;
        private PictureBox pictureBox1;
        private Label Title;
        private LinkLabel Back;
    }
}
namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            UserLabel = new Label();
            PassLabel = new Label();
            UserBox = new TextBox();
            PassBox = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(233, 31);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(47, 15);
            UserLabel.TabIndex = 0;
            UserLabel.Text = "Usuario";
            // 
            // PassLabel
            // 
            PassLabel.AutoSize = true;
            PassLabel.Location = new Point(213, 89);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(67, 15);
            PassLabel.TabIndex = 1;
            PassLabel.Text = "Contraseña";
            // 
            // UserBox
            // 
            UserBox.Location = new Point(151, 49);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(129, 23);
            UserBox.TabIndex = 2;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(151, 107);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(129, 23);
            PassBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(151, 147);
            button1.Name = "button1";
            button1.Size = new Size(129, 48);
            button1.TabIndex = 4;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 228);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(PassBox);
            Controls.Add(UserBox);
            Controls.Add(PassLabel);
            Controls.Add(UserLabel);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserLabel;
        private Label PassLabel;
        private TextBox UserBox;
        private TextBox PassBox;
        private Button button1;
        private PictureBox pictureBox1;
    }
}

namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    partial class Monitor
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
            button1 = new Button();
            Back = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)ShowUsers).BeginInit();
            SuspendLayout();
            // 
            // ShowUsers
            // 
            ShowUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowUsers.Location = new Point(58, 51);
            ShowUsers.Name = "ShowUsers";
            ShowUsers.Size = new Size(529, 324);
            ShowUsers.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(606, 51);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 1;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Back
            // 
            Back.AutoSize = true;
            Back.Location = new Point(681, 21);
            Back.Name = "Back";
            Back.Size = new Size(39, 15);
            Back.TabIndex = 2;
            Back.TabStop = true;
            Back.Text = "Volver";
            Back.LinkClicked += Back_LinkClicked;
            // 
            // Monitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 435);
            Controls.Add(Back);
            Controls.Add(button1);
            Controls.Add(ShowUsers);
            Name = "Monitor";
            Text = "Monitor";
            ((System.ComponentModel.ISupportInitialize)ShowUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ShowUsers;
        private Button button1;
        private LinkLabel Back;
    }
}
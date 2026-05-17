using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_II___Ingenieria_de_software_II___MVC.VISTA
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginForm = new Login();
            LoginForm.Show();
        }
    }
}

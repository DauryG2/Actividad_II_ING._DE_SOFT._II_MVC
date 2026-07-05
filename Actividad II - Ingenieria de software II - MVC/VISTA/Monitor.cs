using Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    public partial class Monitor : Form
    {
        private MonitorController _controller;
        private string _rolUsuarioLogueado;

        public Monitor(string rol)
        {
            InitializeComponent();
            _controller = new MonitorController();
            ShowUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefrescarTabla();
            _rolUsuarioLogueado = rol;
            ShowUsers.Columns[0].HeaderText = "Id";
            ShowUsers.Columns[1].HeaderText = "Nombre";
            ShowUsers.Columns[2].HeaderText = "Apellido";
            ShowUsers.Columns[3].HeaderText = "Rol";
        }
        private void RefrescarTabla()
        {
            try
            {
                DataTable dt = _controller.ObtenerUsuarios();
                ShowUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string destino = _controller.DeterminarPantallaDestino(_rolUsuarioLogueado);

            if (destino == "TEACHER")
            {
                this.Hide();
                Teacher TeacherForm = new Teacher();
                TeacherForm.Show();
            }
            else if (destino == "ADMIN")
            {
                this.Hide();
                Admin AdminForm = new Admin();
                AdminForm.Show();
            }
            else
            {
                this.Hide();
                Login LoginForm = new Login();
                LoginForm.Show();
            }
        }
    }
}
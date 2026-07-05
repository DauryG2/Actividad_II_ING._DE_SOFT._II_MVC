using Actividad_II___Ingenieria_de_software_II___MVC.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR;
using System.Runtime.CompilerServices;

namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    public partial class Edit : Form
    {
        private MonitorController _controller;
        private UserController _editRepo = new UserController();

        public Edit()
        {
            InitializeComponent();
            _controller = new MonitorController();
            RefrescarTabla();
            dtUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtUsers.Columns[0].HeaderText = "Id";
            dtUsers.Columns[1].HeaderText = "Nombre";
            dtUsers.Columns[2].HeaderText = "Apellido";
            dtUsers.Columns[3].HeaderText = "Usuario";
            dtUsers.Columns[4].HeaderText = "Rol";
            dtUsers.MultiSelect = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text.Trim();
            string lastname = lastnameBox.Text.Trim();
            string user = userBox.Text.Trim();
            string rol = rolBox.Text.Trim();

            string resultado = _editRepo.EditarUsuario(name, lastname, user, rol);

            if (resultado == "EXITO")
                MessageBox.Show("Usuario actualizado.");
            else if (resultado == "CAMPOS_VACIOS")
                MessageBox.Show("Por favor, complete todos los campos.");
            else
                MessageBox.Show(resultado);
            RefrescarTabla();
        }
        private void RefrescarTabla()
        {
            try
            {
                DataTable dt = _controller.ObtenerUsuarios();
                dtUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

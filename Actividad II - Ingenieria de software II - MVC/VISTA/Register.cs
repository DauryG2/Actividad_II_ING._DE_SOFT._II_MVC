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
    public partial class Register : Form
    {
        private RegisterController _controller;

        public Register()
        {
            InitializeComponent();
            _controller = new RegisterController();
            CargarComboRoles();
        }
        private void CargarComboRoles()
        {
            try
            {
                DataTable dt = _controller.CargarRoles();
                RolsCombo.DataSource = dt;
                RolsCombo.DisplayMember = "rol_name";
                RolsCombo.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {
            string resultado = _controller.RegistrarNuevoUsuario(
                NameBox.Text,
                Last_nameBox.Text,
                UserBox.Text,
                PasswordBox.Text,
                RolsCombo.SelectedValue
            );

            if (resultado == "CAMPOS_VACIOS")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else if (resultado == "EXITO")
            {
                NameBox.Clear();
                Last_nameBox.Clear();
                UserBox.Clear();
                PasswordBox.Clear();

                MessageBox.Show("Usuario registrado exitosamente.");
            }
            else
            {
                MessageBox.Show(resultado); // Muestra el mensaje de error de la BD
            }
        }
    }
}

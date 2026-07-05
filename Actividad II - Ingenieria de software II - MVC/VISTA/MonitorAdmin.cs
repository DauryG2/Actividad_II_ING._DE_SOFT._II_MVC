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
using Actividad_II___Ingenieria_de_software_II___MVC.MODELO;

namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    public partial class MonitorAdmin : Form
    {
        private MonitorController _controller;
        private string _rolUsuarioLogueado;
        private UserRepo _userRepo;

        public MonitorAdmin(string rol)
        {
            InitializeComponent();
            _controller = new MonitorController();
            _userRepo = new UserRepo();
            ShowUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefrescarTabla();
            _rolUsuarioLogueado = rol;
            ShowUsers.Columns[0].HeaderText = "Id";
            ShowUsers.Columns[1].HeaderText = "Nombre";
            ShowUsers.Columns[2].HeaderText = "Apellido";
            ShowUsers.Columns[3].HeaderText = "Usuario";
            ShowUsers.Columns[4].HeaderText = "Rol";
            ShowUsers.MultiSelect = false;
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

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int? maybeId = _controller.ObtenerIdSeleccionado(ShowUsers);
            if (!maybeId.HasValue)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = maybeId.Value;
            var confirm = MessageBox.Show($"¿Desea eliminar el usuario con ID {userId}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                bool eliminado = _controller.EliminarUsuarioPorId(userId);
                if (eliminado)
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit();
            editForm.Show();
        }
    }
}

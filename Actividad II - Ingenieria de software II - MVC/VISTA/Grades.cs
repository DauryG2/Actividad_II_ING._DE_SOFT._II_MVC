using Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR;
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

namespace Actividad_II___Ingenieria_de_software_II___MVC.VISTA
{
    public partial class Grades : Form
    {
        private MonitorController _controller = new MonitorController();
        private GradesController _gradesController = new GradesController();
        private SubjectsController _sController = new SubjectsController();
        private string _rolUsuarioLogueado;

        public Grades(string rol)
        {
            InitializeComponent();
            _sController = new SubjectsController();
            _controller = new MonitorController();
            _rolUsuarioLogueado = rol;
            RefrescarTabla();
            ShowUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (ShowUsers.Columns.Count >= 7)
            {
                ShowUsers.Columns[0].Visible = false;
                ShowUsers.Columns[1].Visible = false;
                ShowUsers.Columns[2].HeaderText = "Usuario";
                ShowUsers.Columns[3].HeaderText = "Nombre";
                ShowUsers.Columns[4].HeaderText = "Apellido";
                ShowUsers.Columns[5].HeaderText = "Materia";
                ShowUsers.Columns[6].HeaderText = "Nota";
            }
        }



        private void RefrescarTabla()
        {
            try
            {
                DataTable dt = _gradesController.ObtenerNotas();
                ShowUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGrades addGradesForm = new AddGrades();
            addGradesForm.FormClosed += (s, args) => this.Show();
            addGradesForm.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditGrades editGradesForm = new EditGrades();
            editGradesForm.FormClosed += (s, args) => { this.Show(); RefrescarTabla(); };
            editGradesForm.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int? maybeUserId = _controller.ObtenerIdSeleccionado(ShowUsers);
            if (!maybeUserId.HasValue)
            {
                MessageBox.Show("Seleccione una nota para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = maybeUserId.Value;
            DataGridViewRow row = ShowUsers.SelectedRows.Count > 0 ? ShowUsers.SelectedRows[0] : ShowUsers.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("No se encontró la fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (row.Cells.Count < 2 || row.Cells[1].Value == null || !int.TryParse(row.Cells[1].Value.ToString(), out int subjectId))
            {
                MessageBox.Show("No se pudo obtener el ID de la asignatura asociada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"¿Desea eliminar la nota del usuario {userId} para la materia {subjectId}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _gradesController.EliminarNota(userId, subjectId);
                MessageBox.Show("Nota eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la nota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

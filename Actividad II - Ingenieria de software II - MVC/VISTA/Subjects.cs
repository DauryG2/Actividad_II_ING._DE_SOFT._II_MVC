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
    public partial class Subjects : Form
    {
        private MonitorController _controller = new MonitorController();
        private SubjectsController _sController = new SubjectsController();
        private string _rolUsuarioLogueado;

        public Subjects(string rol)
        {
            InitializeComponent();
            _sController = new SubjectsController();
            _controller = new MonitorController();
            _rolUsuarioLogueado = rol;
            RefrescarTabla();
            ShowUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowUsers.Columns[0].HeaderText = "ID";
            ShowUsers.Columns[1].HeaderText = "Materias";
        }



        private void RefrescarTabla()
        {
            try
            {
                DataTable dt = _sController.ObtenerMaterias();
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
            AddSubjects addSubjectsForm = new AddSubjects();
            addSubjectsForm.FormClosed += (s, args) => this.Show();
            addSubjectsForm.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int? maybeId = _controller.ObtenerIdSeleccionado(ShowUsers);
            if (!maybeId.HasValue)
            {
                MessageBox.Show("Seleccione una asignatura para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int subjectId = maybeId.Value;
            var confirm = MessageBox.Show($"¿Desea eliminar la materia con ID {subjectId}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                bool eliminado = _sController.EliminarMateria(subjectId);
                if (eliminado)
                {
                    MessageBox.Show("Asignatura eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la asignatura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar asignatura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditSubjects editSubjectsForm = new EditSubjects();
            editSubjectsForm.FormClosed += (s, args) => { this.Show(); RefrescarTabla(); };
            editSubjectsForm.Show();
        }
    }
}

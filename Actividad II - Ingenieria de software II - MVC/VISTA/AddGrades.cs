using Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad_II___Ingenieria_de_software_II___MVC.VISTA
{
    public partial class AddGrades : Form
    {
        private SubjectsController _sController = new SubjectsController();
        private UserController _userController = new UserController();
        private GradesController _gradesController = new GradesController();
        public AddGrades()
        {
            _sController = new SubjectsController();
            InitializeComponent();
            dtGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefrescarTabla();
            dtGrades.Columns[0].Visible = false;
            dtGrades.Columns[1].Visible = false;
            dtGrades.Columns[2].HeaderText = "Usuario";
            dtGrades.Columns[3].HeaderText = "Nombre";
            dtGrades.Columns[4].HeaderText = "Apellido";
            dtGrades.Columns[5].HeaderText = "Materia";
            dtGrades.Columns[6].HeaderText = "Nota";

            dtUsers.Columns[0].HeaderText = "Id de usuario";
            dtUsers.Columns[1].HeaderText = "Usuario";
            dtUsers.Columns[2].HeaderText = "Nombre";
            dtUsers.Columns[3].HeaderText = "Apellido";
            dtUsers.Columns[4].Visible = false;

            dtSubject.Columns[0].HeaderText = "Id de materia";
            dtSubject.Columns[1].HeaderText = "Materia";
        }
        private void RefrescarTabla()
        {
            try
            {
                DataTable dt = _gradesController.ObtenerNotas();
                DataTable dtUser = _userController.ObtenerUsuarios();
                DataTable dtSubjects = _sController.ObtenerMaterias();
                dtUsers.DataSource = dtUser;
                dtSubject.DataSource = dtSubjects;
                dtGrades.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            _gradesController.InsertarNota(int.Parse(idBox.Text), int.Parse(subjectBox.Text), decimal.Parse(gradesBox.Text));
            RefrescarTabla();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            RefrescarTabla();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR;

namespace Actividad_II___Ingenieria_de_software_II___MVC.VISTA
{
    public partial class EditSubjects : Form
    {
        private SubjectsController _sController = new SubjectsController();
        public EditSubjects()
        {
            _sController = new SubjectsController();
            InitializeComponent();
            dtSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefrescarTabla();
            dtSubjects.Columns[0].HeaderText = "ID";
            dtSubjects.Columns[1].HeaderText = "Materia";
        }
        private void RefrescarTabla()
        {
            try
            {
                DataTable dt = _sController.ObtenerMaterias();
                dtSubjects.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            _sController.ActualizarMateria(int.Parse(idBox.Text), subjectsBox.Text);
            RefrescarTabla();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            RefrescarTabla();
        }
    }
}

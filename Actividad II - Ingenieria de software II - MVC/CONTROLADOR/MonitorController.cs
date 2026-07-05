using Actividad_II___Ingenieria_de_software_II___MVC.MODELO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR
{
    public class MonitorController
    {
        private UserRepo _UserRepo;

        public MonitorController()
        {
            _UserRepo = new UserRepo();
        }

        public int? ObtenerIdSeleccionado(DataGridView grid)
        {
            if (grid == null)
                return null;

            if (grid.SelectedRows.Count == 0 && grid.CurrentRow == null) 
                return null;

            DataGridViewRow row = grid.SelectedRows.Count > 0 ? grid.SelectedRows[0] : grid.CurrentRow;
            if (row == null) 
                return null;

            object idValue = row.Cells[0].Value;
            if (idValue == null || !int.TryParse(idValue.ToString(), out int userId)) 
                return null;

            return userId;
        }

        public bool EliminarUsuarioPorId(int userId)
        {
            return _UserRepo.EliminarUsuario(userId);
        }

        public DataTable ObtenerUsuarios()
        {
            return _UserRepo.ObtenerUsuarios();
        }

        // Determina a qué pantalla regresar basándose en la existencia del Administrador
        public string DeterminarPantallaDestino(String rolUsuarioActual)
        {
            if (rolUsuarioActual == "Profesor")
            {
                return "TEACHER";
            }
            else if (rolUsuarioActual == "Administrador")
            {
                return "ADMIN";
            }

            return "LOGIN"; 
        }
    }
}

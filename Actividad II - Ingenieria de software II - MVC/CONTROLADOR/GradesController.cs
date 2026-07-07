using Actividad_II___Ingenieria_de_software_II___MVC.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR
{
    internal class GradesController
    {
        private GradesRepo _gradesRepo = new GradesRepo();
        public DataTable ObtenerNotas()
        {
            return _gradesRepo.ObtenerNotas();
        }

        public void InsertarNota(int userId, int subjectId, decimal grade)
        {
            _gradesRepo.InsertarNota(userId, subjectId, grade);
        }

        public void EditarCalificaciones(int userId, int subjectId, decimal grade)
        {
            _gradesRepo.EditarCalificaciones(userId, subjectId, grade);
        }

        public void EliminarNota(int userId, int subjectId)
        {
            _gradesRepo.EliminarNota(userId, subjectId);
        }
    }
}


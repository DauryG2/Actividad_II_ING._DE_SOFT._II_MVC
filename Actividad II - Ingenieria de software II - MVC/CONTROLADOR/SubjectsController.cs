using Actividad_II___Ingenieria_de_software_II___MVC.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR
{
    internal class SubjectsController
    {
        private SubjectsRepo _sRepo = new SubjectsRepo();
        public DataTable ObtenerMaterias()
        {
            return _sRepo.ObtenerMaterias();
        }

        public void InsertarMateria(string subject)
        {
            _sRepo.InsertarMateria(subject);
        }

        public bool EliminarMateria(int subjectId)
        {
            return _sRepo.EliminarMateria(subjectId);
        }

        public void ActualizarMateria(int subjectId, string newSubjectName)
        {
            _sRepo.ActualizarMateria(subjectId, newSubjectName);
        }
    }
}

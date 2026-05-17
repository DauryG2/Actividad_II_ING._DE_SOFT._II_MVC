using Actividad_II___Ingenieria_de_software_II___MVC.MODELO;
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
        private RolRepo _rolRepository;

        public MonitorController()
        {
            _UserRepo = new UserRepo();
            _rolRepository = new RolRepo();
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

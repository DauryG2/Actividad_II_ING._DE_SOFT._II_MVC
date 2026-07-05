using Actividad_II___Ingenieria_de_software_II___MVC.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR
{
    public class RegisterController
    {
        private UserRepo _userRepo;

        public RegisterController()
        {
            _userRepo = new UserRepo();
        }

        public DataTable CargarRoles()
        {
            return _userRepo.ObtenerTodosLosRoles();
        }

        public string RegistrarNuevoUsuario(string name, string lastName, string username, string password, object idRol)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || idRol == null)
            {
                return "CAMPOS_VACIOS";
            }

            try
            {
                bool exito = _userRepo.RegistrarUsuario(name, lastName, username, password, idRol);
                return exito ? "EXITO" : "ERROR";
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }
    }
}

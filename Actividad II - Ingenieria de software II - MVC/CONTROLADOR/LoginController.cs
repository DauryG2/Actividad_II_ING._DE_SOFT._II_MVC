using Actividad_II___Ingenieria_de_software_II___MVC.MODELO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR
{
    public class LoginController
    {
        private UserRepo _usuarioLog;

        public LoginController()
        {
            _usuarioLog = new UserRepo();
        }

        public string IniciarSesion(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "CAMPOS_VACIOS";
            }

            try
            {
                Users user = _usuarioLog.AutenticarUsuario(username, password);

                if (user != null)
                {
                    return user.RolName; 
                }
                else
                {
                    return "INCORRECTO";
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }
    }
}


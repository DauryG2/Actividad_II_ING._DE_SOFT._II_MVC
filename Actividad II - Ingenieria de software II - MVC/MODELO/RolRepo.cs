using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.MODELO
{
    public class RolRepo
    {
        private DbConnection _dbConnection = new DbConnection();

        public DataTable ObtenerTodosLosRoles()
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                using (var cmd = new NpgsqlCommand("SELECT * FROM rols", conn))
                {
                    using var reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener roles: " + ex.Message);
            }
        }
    }
}

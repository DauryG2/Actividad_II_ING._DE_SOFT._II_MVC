using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.MODELO
{
    public class UserRepo
    {
        private DbConnection _dbConnection = new DbConnection();

        public Users AutenticarUsuario(string username, string password)
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "SELECT U.username, U.pass, R.rol_name FROM users U INNER JOIN rols R ON U.id_rol = R.id WHERE U.username = @username AND U.pass = @password;";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Users
                        {
                            Username = reader.GetString(0),
                            Password = reader.GetString(1),
                            RolName = reader.GetString(2)
                        };
                    }
                    return null; // Usuario no encontrado
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }
        }

        public DataTable ObtenerUsuarios()
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "SELECT U.ID, U.name, U.Last_name, R.Rol_name FROM Users U INNER JOIN Rols R On U.ID_Rol = R.ID ORDER BY U.ID;";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using var reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar lista de usuarios: " + ex.Message);
            }
        }

        public bool RegistrarUsuario(string name, string lastName, string username, string password, object idRol)
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "INSERT INTO users (Name, Last_name, Username, Pass, ID_Rol) VALUES (@name, @last_name, @username, @password, @rol_id)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("last_name", lastName);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("rol_id", idRol);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar usuario: " + ex.Message);
            }
        }
    }
}
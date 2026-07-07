using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.MODELO
{
    internal class SubjectsRepo
    {
        private DbConnection _dbConnection = new DbConnection();

        public DataTable ObtenerMaterias()
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "SELECT * FROM subject ORDER BY id";

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
        public void InsertarMateria(string subject)
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "INSERT INTO subject(subject_name) VALUES (@subject);";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("subject", subject);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar materia: " + ex.Message);
            }
        }
        public bool EliminarMateria(int subjectId)
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "DELETE FROM subject WHERE id = @subjectId;";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("subjectId", subjectId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar materia: " + ex.Message);
            }
        }
        public void ActualizarMateria(int subjectId, string newSubjectName)
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "UPDATE subject SET subject_name = @newSubjectName WHERE id = @subjectId;";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("newSubjectName", newSubjectName);
                    cmd.Parameters.AddWithValue("subjectId", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar materia: " + ex.Message);
            }
        }
    }
}

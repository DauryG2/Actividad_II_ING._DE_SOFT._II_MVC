using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_II___Ingenieria_de_software_II___MVC.MODELO
{
    internal class GradesRepo
    {
        private DbConnection _dbConnection = new DbConnection();

        public DataTable ObtenerNotas()
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "SELECT u.id as user_id, s.id as subject_id, u.username as usuario, u.name as nombre, u.last_name as apellido, s.subject_name as materia, g.grade as nota FROM users u JOIN grades g ON g.id_user = u.id JOIN subject s ON s.id = g.id_subject WHERE u.ID_Rol = 3 ORDER BY u.ID";

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
        public void InsertarNota(int userId, int subjectId, decimal grade)
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "INSERT INTO grades (id_user, id_subject, grade) VALUES (@userId, @subjectId, @grade)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@subjectId", subjectId);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la nota: " + ex.Message);
            }
        }
        
        public void EditarCalificaciones(int userId, int subjectId, decimal grade)
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "UPDATE grades SET grade = @grade WHERE id_user = @userId AND id_subject = @subjectId";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@subjectId", subjectId);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar la calificación: " + ex.Message);
            }
        }

        public void EliminarNota(int userId, int subjectId)
        {
            try
            {
                using var conn = _dbConnection.OpenConnection();
                string query = "DELETE FROM grades WHERE id_user = @userId AND id_subject = @subjectId";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@subjectId", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la nota: " + ex.Message);
            }
        }
    }
}

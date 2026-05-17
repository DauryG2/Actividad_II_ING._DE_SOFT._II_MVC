using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Actividad_II___Ingenieria_de_software_II___MVC.MODELO
{
    internal class DbConnection
    {
        string connString = "Host=localhost;Username=postgres;Password=8298;Database=Actividad_II";
        public NpgsqlConnection OpenConnection()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }

    }
}

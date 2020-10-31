using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPuraLibreria
{
    public class DatabaseAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static DataTable CargarTabla(string query)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                DataTable da = new DataTable();
                var output = new SQLiteDataAdapter(query, cnn);
                output.Fill(da);
                return da;
            }
        }

        public static bool Existe(string query)
        {

            using (var db = new SQLiteConnection(LoadConnectionString()))
            {
                return db.ExecuteScalar<int>(query) > 0;
            }

        }

        public static int Cantidad(string query)
        {

            using (var db = new SQLiteConnection(LoadConnectionString()))
            {
                return db.ExecuteScalar<int>(query);
            }

        }

        public static string GetInfo(string query)
        {

            using (var db = new SQLiteConnection(LoadConnectionString()))
            {
                return db.ExecuteScalar<string>(query);
            }

        }

        public static float PrecioTotal(string query)
        {

            using (var db = new SQLiteConnection(LoadConnectionString()))
            {
                return db.ExecuteScalar<float>(query);
            }

        }

        public static void EjecutarConsulta(string query)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(query);
            }
        }
    }
}

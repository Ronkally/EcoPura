using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPuraLibreria
{
    public class DatabaseAccess
    {
        /*
         public static List<> Cargar(){
         
            using(IDbConnection cnn = new SQLiteConnection(Load())){
            var output = cnn.Query<model>(consulta, new DynamicParameters());
            return output.ToList();
            }

            }
         */ 


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataBase
    {
        public static string ConnectionString //se inicializa una propiedad de la clase
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["NWConnectionString"].ConnectionString; 
            }
        }

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conexion = new SqlConnection(ConnectionString); //Error
            conexion.Open(); //para implementarlo con la base de datos
            return conexion;
        }

    }
}

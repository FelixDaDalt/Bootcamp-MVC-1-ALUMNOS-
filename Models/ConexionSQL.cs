using System.Data.SqlClient;
using System.Data.Sql;

namespace WebApplicationAlumnos.Models
{
    public class ConexionSQL
    {
        private static SqlConnection conexion = null;

        public static SqlConnection GetConexion()
        {
            var c = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            string sConexion = c.GetSection("ConnectionStrings:Conexion").Value;
            conexion = new SqlConnection(sConexion);
            return conexion;
        }
    }
}

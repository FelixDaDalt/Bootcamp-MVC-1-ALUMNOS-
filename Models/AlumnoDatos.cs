using System.Data.SqlClient;
using System.Data.Sql;

namespace WebApplicationAlumnos.Models
{
    public class AlumnoDatos
    {
        public List<AlumnoModelo> alumnos()
        {
            var lista = new List<AlumnoModelo>();

            SqlConnection con = ConexionSQL.GetConexion();
            con.Open();
            string consulta = "select * from ALUMNO";
            SqlCommand cmd = new SqlCommand(consulta, con);
            var resultados = cmd.ExecuteReader();

            while (resultados.Read())
            {
                lista.Add(new AlumnoModelo()
                {
                    Apellido = (string)resultados["Apellido"],
                    Nombre = (string)resultados["Nombre"],
                    DNI = (int)resultados["DNI"],
                });
            }

            return lista;

        }


    }
}

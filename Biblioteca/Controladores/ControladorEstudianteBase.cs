using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controladores
{
    public class ControladorEstudianteBase
    {
        private readonly string conexion;

        public ControladorEstudianteBase(string cadenaConexion)
        {
            conexion = cadenaConexion;
        }

        public int ObtenerCantidadEstudiantesMatriculados()
        {
            int cantidad = 0;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("ObtenerEstudiantesMatriculados", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cantidad++;



                }

                reader.Close();
            }

            return cantidad;
        }
    }
}

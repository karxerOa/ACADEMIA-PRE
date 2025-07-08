using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controladores
{
    public class ControladorCarreras
    {
        public string cadenaConexion;
        public ControladorCarreras(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        public List<Carrera> ObtenerCarreras()
        {
            List<Carrera> listaCarreras = new List<Carrera>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"
                SELECT c.id_carrera, c.Nombre_carrera,
                       a.id_area, a.Tipo_area, a.Denominacion
                FROM Carrera c
                INNER JOIN Area a ON c.id_area = a.id_area";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Carrera carrera = new Carrera
                    {
                        Id_carrera = Convert.ToInt32(reader["id_carrera"]),
                        Nombre_carrera = reader["Nombre_carrera"].ToString(),
                        Area = new Area
                        {
                            Id_area = reader["id_area"].ToString(),
                            Tipo_area = reader["Tipo_area"].ToString(),
                            Denominacion = reader["Denominacion"].ToString()
                        }
                    };

                    listaCarreras.Add(carrera);
                }
            }

            return listaCarreras;
        }


    }
}

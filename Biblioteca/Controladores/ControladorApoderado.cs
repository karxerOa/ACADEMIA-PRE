using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Controladores
{
    public class ControladorApoderado
    {
        private string cadenaConexion;

        public ControladorApoderado(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public int InsertarApoderado(Apoderado apoderado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("InsertarApoderado", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", apoderado.nombre_apoderado);
                    cmd.Parameters.AddWithValue("@Telefono", apoderado.telefono_apoderado);

                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int idApoderado))
                    {
                        return idApoderado; // IDENTITY generado
                    }
                    else
                    {
                        return -1; // Error al obtener el ID
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar apoderado: " + ex.Message);
                return -1;
            }
        }
    }
}

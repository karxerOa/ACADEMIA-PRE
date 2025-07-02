using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMIA_PRE
{
    public class ControladorUsuario
    {
        private string cadenaConexion;
        public ControladorUsuario(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public bool ValidarUsuario(string nombre, string contraseña, string rol)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("ValidarUsuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message);
                return false;
            }
        }

        public void InsertarUsuario(string nombre, string contraseña, string rol)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("InsertarUsuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario insertado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar usuario: " + ex.Message);
            }
        }
    }
    
}

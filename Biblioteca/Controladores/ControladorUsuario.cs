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

        public string InsertarUsuario(string nombre, string contraseña, string rol)
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

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string idUsuario = resultado.ToString();
                        MessageBox.Show("Usuario insertado correctamente. ID: " + idUsuario);
                        return idUsuario;
                    }
                    else
                    {
                        MessageBox.Show("Usuario insertado, pero no se recuperó el ID.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar usuario: " + ex.Message);
                return null;
            }
        }
        public bool UsuarioYaExiste(string nombre)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE Nombre = @Nombre", conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar nombre de usuario: " + ex.Message);
                return true; // Por seguridad, mejor asumir que sí existe si hay error
            }
        }
        public void EliminarUsuario(string idUsuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE id_usuario = @id", conn);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }
    }
}

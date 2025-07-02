using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public class Usuario
    {
        private string user;
        private string contraseña;
        private string rol;

        public string User
        {
            get { return user; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre de usuario no puede ir blanco");
                user = value;
            }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La contraseña no puede ir en blanco");
                contraseña = value;
            }
        }
        public string Rol
        {
            get { return rol; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El rol no puede ir en blanco");
                rol = value;
            }
        }
        public Usuario() { }

        public Usuario(string user, string contraseña, string rol)
        {
            User = user;
            Contraseña = contraseña;
            Rol = rol;  
        }
        public bool ValidarConSP(string CadenaConexion)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("ValidarUsuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreUsuario", this.User);
                    cmd.Parameters.AddWithValue("@Contraseña", this.Contraseña);
                    cmd.Parameters.AddWithValue("@Rol", this.Rol);

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

    }
}

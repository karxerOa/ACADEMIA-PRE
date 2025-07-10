using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Controladores
{
    public class ControladorEstudiante
    {
        public string cadenaConexion;
        public ControladorEstudiante(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        public bool InsertarEstudiante(Estudiante estudiante)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("InsertarEstudiante", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombres", estudiante.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido_paterno", estudiante.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@Apellido_materno", estudiante.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@Edad", estudiante.Edad);
                    cmd.Parameters.AddWithValue("@DNI", estudiante.DNI);
                    cmd.Parameters.AddWithValue("@Telefono", estudiante.Telefono);

                    // Si el estudiante tiene apoderado, se agrega su ID; si no, se envía NULL
                    if (estudiante.Apoderado != null)
                        cmd.Parameters.AddWithValue("@id_apoderado", estudiante.Apoderado.Id_apoderado);
                    else
                        cmd.Parameters.AddWithValue("@id_apoderado", DBNull.Value);

                    cmd.Parameters.AddWithValue("@id_carrera", estudiante.Carrera.Id_carrera);
                    cmd.Parameters.AddWithValue("@id_usuario", estudiante.Usuario.Id_usuario1);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Estudiante registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar estudiante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool RegistrarEstudianteConUsuario(Estudiante estudiante)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insertar el Usuario
                    SqlCommand cmdUsuario = new SqlCommand("InsertarUsuario", conn, transaction);
                    cmdUsuario.CommandType = CommandType.StoredProcedure;

                    cmdUsuario.Parameters.AddWithValue("@Nombre", estudiante.Usuario.User);
                    cmdUsuario.Parameters.AddWithValue("@Contraseña", estudiante.Usuario.Contraseña);
                    cmdUsuario.Parameters.AddWithValue("@Rol", estudiante.Usuario.Rol);

                    // Obtener el ID generado
                    string idUsuario = (string)cmdUsuario.ExecuteScalar(); 
                    estudiante.Usuario.Id_usuario = idUsuario;

                    // 2. Insertar el Estudiante
                    SqlCommand cmdEstudiante = new SqlCommand("InsertarEstudiante", conn, transaction);
                    cmdEstudiante.CommandType = CommandType.StoredProcedure;

                    cmdEstudiante.Parameters.AddWithValue("@Nombres", estudiante.Nombre);
                    cmdEstudiante.Parameters.AddWithValue("@Apellido_paterno", estudiante.ApellidoPaterno);
                    cmdEstudiante.Parameters.AddWithValue("@Apellido_materno", estudiante.ApellidoMaterno);
                    cmdEstudiante.Parameters.AddWithValue("@Edad", estudiante.Edad);
                    cmdEstudiante.Parameters.AddWithValue("@DNI", estudiante.DNI);
                    cmdEstudiante.Parameters.AddWithValue("@Telefono", estudiante.Telefono);

                    if (estudiante.Apoderado != null)
                        cmdEstudiante.Parameters.AddWithValue("@id_apoderado", estudiante.Apoderado.Id_apoderado);
                    else
                        cmdEstudiante.Parameters.AddWithValue("@id_apoderado", DBNull.Value);

                    cmdEstudiante.Parameters.AddWithValue("@id_carrera", estudiante.Carrera.Id_carrera);
                    cmdEstudiante.Parameters.AddWithValue("@id_usuario", idUsuario);

                    cmdEstudiante.ExecuteNonQuery();

                    // Si todo va bien, confirmamos la transacción
                    transaction.Commit();
                    MessageBox.Show("Estudiante y usuario registrados correctamente.");
                    return true;
                }
                catch (Exception ex)
                {
                    // Si algo falla, revertimos todo
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message + "\nSe canceló el registro completo.");
                    return false;
                }
            }

        }
        public DataTable ObtenerEstudiantesResumen()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT 
                    E.id_estudiante AS [ID],
                    E.Nombres AS [Nombre],
                    E.Apellido_paterno AS [Apellido Paterno],
                    C.Nombre_carrera AS [Carrera]
                FROM Estudiante E
                INNER JOIN Carrera C ON E.id_carrera = C.id_carrera", conn);

                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }       

    }
}

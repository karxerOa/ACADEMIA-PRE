using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ACADEMIA_PRE
{
    public partial class MenúDocente : Form
    {
        public MenúDocente()
        {
            InitializeComponent();
            idDocenteActual = ""; // Valor por defecto
        }
        //Nombre del docente
        private string idDocenteActual; // Variable para guardar el ID

        // Constructor modificado para recibir el ID
        public MenúDocente(string idDocente)
        {
            InitializeComponent();
            idDocenteActual = idDocente; // Guardar el ID
        }

        private void MenúDocente_Load(object sender, EventArgs e)
        {
            lbl_NombreDocente_Click(this, new EventArgs());
            //dgvCursos_CellContentClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void lbl_NombreDocente_Click(object sender, EventArgs e)
        {
            string idDocente = "D001";

            string nombreCompleto = ObtenerNombreCompleto(idDocente);

            if (!string.IsNullOrEmpty(nombreCompleto))
            {
                lbl_NombreDocente.Text = nombreCompleto;
            }
            else
            {
                lbl_NombreDocente.Text = "Docente no encontrado";
            }
        }

        private string ObtenerNombreCompleto(string idDocente)
        {
            using (SqlConnection connection = new SqlConnection(ConexionBD.CadenaConexion))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Nombre, Apellido_paterno, Apellido_materno FROM Docente WHERE id_docente = @id_docente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_docente", idDocente);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombre = reader["Nombre"].ToString();
                                string apellidoPaterno = reader["Apellido_Paterno"].ToString();
                                string apellidoMaterno = reader["Apellido_Materno"].ToString();

                                return $"{nombre} {apellidoPaterno} {apellidoMaterno}";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el nombre del docente: " + ex.Message,
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return string.Empty;

            //Mostrar cursos del docente


        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idDocente = "D001"; // Aquí deberías usar el ID real del login
            DataTable cursos = ObtenerCursosDocente(idDocente);
            if (cursos.Rows.Count > 0)
            {
                dgvCursos.DataSource = cursos;
                // Configurar columnas según tu diseño
                dgvCursos.Columns["id_curso"].HeaderText = "ID Curso";
                dgvCursos.Columns["Denominacion"].HeaderText = "Denominación";
            }
            else
            {
                MessageBox.Show("No tienes cursos asignados", "Información",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private DataTable ObtenerCursosDocente(string idDocente)
        {
            DataTable cursos = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConexionBD.CadenaConexion))
            {
                try
                {
                    connection.Open();
                    string query = @"
                                     SELECT 
                                        c.id_curso, 
                                        c.Denominacion,
                                        FROM Curso c
                                        LEFT JOIN Detalle_curso dc ON c.IdCurso = dc.id_curso";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_docente", idDocente);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(cursos);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los cursos del docente: " + ex.Message,
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return cursos;

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }
    


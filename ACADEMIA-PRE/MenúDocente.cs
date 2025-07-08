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
            dgvCursos_CellContentClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void lbl_NombreDocente_Click(object sender, EventArgs e)
        {
            string nombreDocente = ObtenerNombreDocente(idDocenteActual); // Usar el ID real

            if (!string.IsNullOrEmpty(nombreDocente))
            {
                lbl_NombreDocente.Text = nombreDocente;
            }
            else
            {
                lbl_NombreDocente.Text = "Docente no encontrado";
            }
        }

        private string ObtenerNombreDocente(string idDocente)
        {
            string nombreDocente = "";

            using (SqlConnection connection = new SqlConnection(ConexionBD.CadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Modificamos la consulta para obtener nombre completo
                    string query = "SELECT Nombre, Apellido_paterno, Apellido_materno FROM Docente WHERE id_docente = @id_docente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_docente", idDocente);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombre = reader["Nombre"].ToString();
                                string apellidoPaterno = reader["Apellido_paterno"].ToString();
                                string apellidoMaterno = reader["Apellido_materno"].ToString();

                                // Concatenamos el nombre completo
                                nombreDocente = $"{nombre} {apellidoPaterno} {apellidoMaterno}";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el nombre del docente: " + ex.Message,
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return nombreDocente;
        }

        //Mostrar cursos del docente

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    // Usar índice en lugar de nombre
            //    string idCurso = dgvCursos.Rows[e.RowIndex].Cells[0].Value.ToString(); // Primera columna
            //    string denominacion = dgvCursos.Rows[e.RowIndex].Cells[1].Value.ToString(); // Segunda columna

            //    MessageBox.Show($"Curso seleccionado: {denominacion} (ID: {idCurso})");
            //}
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        //        private void CargarCursosDocente()
        //        {
        //            DataTable cursos = ObtenerCursosDocente(idDocenteActual); // Usar el ID real

        //            if (cursos.Rows.Count > 0)
        //            {
        //                dgvCursos.DataSource = cursos;

        //                // Configurar columnas
        //                if (dgvCursos.Columns["id_curso"] != null)
        //                    dgvCursos.Columns["id_curso"].HeaderText = "ID Curso";
        //                if (dgvCursos.Columns["Denominacion"] != null)
        //                    dgvCursos.Columns["Denominacion"].HeaderText = "Denominación";
        //            }
        //            else
        //            {
        //                MessageBox.Show("No tienes cursos asignados", "Información",
        //                               MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //        private DataTable ObtenerCursosDocente(string idDocente)
        //        {
        //            DataTable cursos = new DataTable();

        //            using (SqlConnection connection = new SqlConnection(ConexionBD.CadenaConexion))
        //            {
        //                try
        //                {
        //                    connection.Open();

        //                    string query = "SELECT id_curso, Denominacion FROM Curso WHERE id_docente = @id_docente";

        //                    using (SqlCommand command = new SqlCommand(query, connection))
        //                    {
        //                        command.Parameters.AddWithValue("@id_docente", idDocente);

        //                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //                        {
        //                            adapter.Fill(cursos);
        //                        }
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Error al obtener los cursos del docente: " + ex.Message,
        //                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }

        //            return cursos;
        //        }
    }
}

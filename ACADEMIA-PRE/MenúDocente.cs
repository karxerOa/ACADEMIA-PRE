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
        }
        //Nombre del docente

        public MenúDocente(string idDocente)
        {
            InitializeComponent();

        }

        private void MenúDocente_Load(object sender, EventArgs e)
        {
            lbl_NombreDocente_Click(this, new EventArgs());
            dgvCursos_CellContentClick(sender, new DataGridViewCellEventArgs(0, 0));
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
                                string apellidoPaterno = reader["Apellido_paterno"].ToString();
                                string apellidoMaterno = reader["Apellido_materno"].ToString();

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
        }


        //Mostrar cursos del docente

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idDocente = "D001"; // Ajusta según tu lógica

            DataTable cursos = ObtenerCursosDataTable(idDocente);

            if (cursos.Rows.Count > 0)
            {
                dgvCursos.DataSource = cursos;
                dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgvCursos.DataSource = null;
                MessageBox.Show("El docente no tiene cursos asignados", "Información",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private DataTable ObtenerCursosDataTable(string idDocente)
        {
            DataTable cursos = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConexionBD.CadenaConexion))
            {
                try
                {
                    connection.Open();

                    // Query que agrupa los temas por curso
                    string query = @"
                    SELECT 
                        c.id_curso, 
                        c.Denominacion
                    FROM Curso c
                    INNER JOIN Detalle_curso dc ON c.id_curso = dc.id_curso";

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

<<<<<<< HEAD
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }
    
=======
>>>>>>> 4f7435830d96e1266193dc512b50dfeff558f24b

        private void btnVerDetalle_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificar que haya al menos una fila seleccionada en el DataGridView
                if (dgvCursos.SelectedRows.Count > 0)
                {
                    // Obtener el ID del curso seleccionado (asegurando no nulo)
                    var selectedRow = dgvCursos.SelectedRows[0];
                    string idCurso = selectedRow.Cells["id_curso"].Value?.ToString();
                    string denominacionCurso = selectedRow.Cells["Denominacion"].Value?.ToString();

                    // Validar que se hayan obtenido datos válidos
                    if (!string.IsNullOrEmpty(idCurso) && !string.IsNullOrEmpty(denominacionCurso))
                    {
                        // Crear y mostrar el formulario de detalle, pasándole los datos necesarios
                        DetalleCurso formDetalle = new DetalleCurso(idCurso, denominacionCurso);
                        formDetalle.Show();
                    }
                    else
                    {
                        MessageBox.Show("El curso seleccionado no tiene datos válidos.",
                                        "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un curso para ver el detalle.",
                                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el detalle del curso: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
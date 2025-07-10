using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMIA_PRE
{
    public partial class DetalleCurso : Form
    {
        public DetalleCurso(string idCurso, string denominacion)
        {
            InitializeComponent();
        }

        private void DetalleCurso_Load(object sender, EventArgs e)
        {
            lbl_NombreCurso_Click(this, new EventArgs(), "1");
        }

        private void bttnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_NombreCurso_Click(object sender, EventArgs e, string id_curso)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionBD.CadenaConexion))
                {
                    string query = "SELECT Denominacion FROM Curso WHERE id_curso = @id_curso";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_curso", id_curso);
                    connection.Open();

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                        lbl_NombreCurso.Text = resultado.ToString();
                    else
                        lbl_NombreCurso.Text = "Curso no encontrado.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el nombre del curso: " + ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

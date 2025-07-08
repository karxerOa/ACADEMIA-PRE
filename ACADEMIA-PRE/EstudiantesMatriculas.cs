using Biblioteca.Controladores;
using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMIA_PRE
{
    public partial class EstudiantesMatriculas : Form
    {
        public EstudiantesMatriculas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EstudiantesMatriculas_Load(object sender, EventArgs e)
        {
            ControladorEstudiante controlador = new ControladorEstudiante(ConexionBD.CadenaConexion);
            DataTable tabla = controlador.ObtenerEstudiantesResumen();

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay estudiantes registrados.");
                return;
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = tabla;
        }
    }
}

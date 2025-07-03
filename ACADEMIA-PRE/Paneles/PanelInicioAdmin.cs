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

namespace ACADEMIA_PRE.Paneles
{
    public partial class PanelInicioAdmin : Form
    {
        public PanelInicioAdmin()
        {
            InitializeComponent();
        }

        private void PanelInicioAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lbMatriculados_Click(object sender, EventArgs e)
        {
            ControladorEstudianteBase controlador = new ControladorEstudianteBase(ConexionBD.CadenaConexion);

            int total = controlador.ObtenerCantidadEstudiantesMatriculados();
            lbMatriculados.Text = $"Activos: {total}";
        }

        private void lblRegistrdos_Click(object sender, EventArgs e)
        {

        }
    }
}

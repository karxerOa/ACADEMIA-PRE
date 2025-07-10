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
using System.Data.SqlClient;

namespace ACADEMIA_PRE.PanelesAdmin
{
    public partial class PanelInicioAdmin : Form
    {
        public PanelInicioAdmin()
        {
            InitializeComponent();
            ContarEstudiantes();
        }

        private void PanelInicioAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void ContarEstudiantes()
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD.CadenaConexion))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_ContarEstudiantes", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    int total = (int)cmd.ExecuteScalar(); // porque COUNT(*) retorna un solo valor

                    LBESTUDIANTESregsitrados.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

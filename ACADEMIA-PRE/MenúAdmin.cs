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
    public partial class MenúAdmin : Form
    {
        public MenúAdmin()
        {
            InitializeComponent();
            AbrirFormularioHijo(new Paneles.PanelInicioAdmin());
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Paneles.PanelInicioAdmin());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormularioHijo(Form formHijo)
        {
            panelContenedor.Controls.Clear(); 
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

    }
}

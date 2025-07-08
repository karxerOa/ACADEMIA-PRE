using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMIA_PRE.PanelesAdmin
{
    public partial class PanelGestEstu : Form
    {
        public PanelGestEstu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntradaRegistrar_Click(object sender, EventArgs e)
        {
            PanelRegistrarEstudiante frm = new PanelRegistrarEstudiante();
            frm.ShowDialog();
        }
    }
}

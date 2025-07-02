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
using Biblioteca;
namespace ACADEMIA_PRE
{
    public partial class USUARIO : Form
    {
        public USUARIO()
        {
            InitializeComponent();
        }
        //SqlConnection conexion = new SqlConnection("Server= LAPTOP-LS9JNIH1; datebase= AcademiaPre; integrated security=true");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuAdmin_Click(object sender, EventArgs e)
        {
            AbrirLoginConRol("Administrador");
        }

        
        private void btnUsuDocente_Click(object sender, EventArgs e)
        {
            AbrirLoginConRol("Docente");
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            AbrirLoginConRol("Estudiante");
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirLoginConRol(string rolSeleccionado)
        {
            this.Hide(); // Oculta el formulario actual

            Login login = new Login(rolSeleccionado);

           
            login.FormClosed += (s, args) => this.Show();

            login.Show();
        }
    }
}

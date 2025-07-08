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
    public partial class Login : Form
    {
        private string rolSeleccionado;
        public Login(string rol)
        {
            InitializeComponent();
            rolSeleccionado = rol;
            lblRol.Text = "Rol: " + rolSeleccionado;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            ControladorUsuario controlador = new ControladorUsuario(ConexionBD.CadenaConexion);

            if (controlador.ValidarUsuario(nombre, contraseña, rolSeleccionado))
            {
                MessageBox.Show($"Bienvenido {nombre} - Rol: {rolSeleccionado}");

                if (rolSeleccionado == "Administrador")
                    new MenúAdmin().Show();
                else if (rolSeleccionado == "Docente")
                    new MenúDocente().Show();
                else
                    new MenúEstudiante().Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
